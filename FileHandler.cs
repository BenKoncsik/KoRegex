using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoRegex
{
    public class FileHandler
    {
        private readonly string _sourceDirectory;
        private readonly string _targetDirectory;
        private readonly RegexOptionsJson _regexOptions;

        public FileHandler(string sourceDirectory, string targetDirectory, RegexOptionsJson regexOptions)
        {
            _sourceDirectory = sourceDirectory;
            _targetDirectory = targetDirectory;
            _regexOptions = regexOptions;
        }

        public void HandleFiles()
        {
            var csFiles = Directory.GetFiles(_sourceDirectory, $"*.{_regexOptions.FileType}", SearchOption.AllDirectories);
            int totalFiles = csFiles.Length;
            int fileIndex = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (var file in csFiles)
            {
                ProcessSingleFile(file);
                fileIndex++;
               if(!Start.Silent) UpdateProgress(fileIndex, totalFiles);
            }

            stopwatch.Stop();
            Console.WriteLine($"\nCompleted in {stopwatch.Elapsed.TotalSeconds:F3} seconds.");
        }
        private void UpdateProgress(int fileIndex, int totalFiles)
        {
            double percent = (double)fileIndex / totalFiles;
            int progressBarWidth = Console.WindowWidth - 20; 
            int progress = (int)(percent * progressBarWidth);
            string progressBar = new String('=', progress) + '>';

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"{fileIndex}/{totalFiles} [{progressBar.PadRight(progressBarWidth)}] {percent:P0}\r");
        }
        private void ProcessSingleFile(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            string modifiedContent = FileProcessor.ModifyFileContent(fileContent, _regexOptions);

            string fileName = Path.GetFileName(filePath);
            string newFileName = $"Debug{fileName}";
            string newFilePath = Path.Combine(_targetDirectory, newFileName);

            File.WriteAllText(newFilePath, modifiedContent);
        }
    }
}
