using Newtonsoft.Json;


namespace KoRegex
{
    public class Start
    {
        private static string JsonFilePath = "./Regex/Regex.json";
        private static string SourceDirectory = "";
        private static string TargetDirectory = "";
        private static string RegexName = "";
        public static bool Silent { get; set; } = false;
        public Start(string[] args) {
            foreach (string arg in args)
            {
                if (arg.StartsWith("-path") || arg.StartsWith("-p"))
                {
                    int index = Array.IndexOf(args, arg);
                    SourceDirectory = index + 1 < args.Length ? args[index + 1] : "";
                }
                else if (arg.StartsWith("-regexjson") || arg.StartsWith("-rj"))
                {
                    int index = Array.IndexOf(args, arg);
                    JsonFilePath = index + 1 < args.Length ? args[index + 1] : JsonFilePath;
                }
                else if (arg.StartsWith("-o") || arg.StartsWith("-output"))
                {
                    int index = Array.IndexOf(args, arg);
                    TargetDirectory = index + 1 < args.Length ? args[index + 1] : "";
                }

                else if (arg.StartsWith("-rn") || arg.StartsWith("-regexname"))
                {
                    int index = Array.IndexOf(args, arg);
                    RegexName = index + 1 < args.Length ? args[index + 1] : "";
                }


                else if (arg.StartsWith("-s") || arg.StartsWith("-Silent"))
                {
                    Silent = true;
                }
            }

            if (string.IsNullOrEmpty(SourceDirectory))
            {
                Console.Write("Please enter the source directory path: ");
                SourceDirectory = Console.ReadLine();
            }

             if (string.IsNullOrEmpty(TargetDirectory))
            {
                Console.Write("Please enter the source directory path (If it is left empty it will put it in the source directory/Debug map by default): ");
                TargetDirectory = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(TargetDirectory))
            {
                TargetDirectory = SourceDirectory + "/Debug";
            }

            if (!Directory.Exists(TargetDirectory))
            {
                Console.WriteLine($"The target directory does not exist, creating it: {TargetDirectory}");
                Directory.CreateDirectory(TargetDirectory);
            }
            else
            {
                ClearDirectory(TargetDirectory);
            }


            List<RegexOptionsJson> regexOptions = LoadRegexOptions(JsonFilePath);
            RegexOptionsJson? selectedOption;
            if (string.IsNullOrEmpty(RegexName))
            {
                selectedOption = SelectRegexOption(regexOptions);
            }
            else
            {
                selectedOption = regexOptions.FirstOrDefault(x => x.Name == RegexName);
                if(selectedOption == null)
                {
                    selectedOption = SelectRegexOption(regexOptions);
                }
            }

            new FileHandler(SourceDirectory, TargetDirectory, selectedOption).HandleFiles();
        }

        private static void ClearDirectory(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private static List<RegexOptionsJson> LoadRegexOptions(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var options = JsonConvert.DeserializeObject<List<RegexOptionsJson>>(json);
            return options;
        }

        private static RegexOptionsJson SelectRegexOption(List<RegexOptionsJson> options)
        {
            if (options == null || options.Count == 0)
            {
                Console.WriteLine("No regex options available.");
                return null;
            }
            int currentIndex = 0;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < options.Count; i++)
                {
                    if (i == currentIndex)
                    {
                        Console.WriteLine($"> {options[i].Name}");
                    }
                    else
                    {
                        Console.WriteLine($"  {options[i].Name}");
                    }
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    currentIndex = (currentIndex - 1 + options.Count) % options.Count;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    currentIndex = (currentIndex + 1) % options.Count;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }

            return options[currentIndex];
        }
    }
}
