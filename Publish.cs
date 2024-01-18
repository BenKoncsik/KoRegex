using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KoRegex
{
#if PUBLISH
    public class Publish
    {
       private string[] publishProfiles = { "linux-x64", "osx-arm64", "win-x64" };
        private string projectDirectory = "../../..";
        public Publish(string[] args) 
        {
            foreach (string arg in args)
            {
                if (arg.StartsWith("-csprojpath") || arg.StartsWith("-csp"))
                {
                    int index = Array.IndexOf(args, arg);
                    projectDirectory = index + 1 < args.Length ? args[index + 1] : "";
                }
            }
                Run();
        }
        private void Run()
        {
            foreach (var profile in publishProfiles)
            {
                Process.Start("dotnet", $"publish {projectDirectory}/KoRegex.csproj -p:PublishProfile={profile}").WaitForExit();

                string publishDirectory = $"{projectDirectory}/bin/Release/net8.0/publish/{profile}";
                string zipFile = Path.Combine("PublishedZips", $"{profile}.zip");
                Console.WriteLine($"Publish path: {publishDirectory}");
                Console.WriteLine($"Zip path: {zipFile}");
                if (!Directory.Exists(publishDirectory))
                {
                    Directory.CreateDirectory(publishDirectory);
                }

                if (!Directory.Exists("PublishedZips"))
                {
                    Directory.CreateDirectory("PublishedZips");
                }

                if (File.Exists(zipFile))
                {
                    File.Delete(zipFile); 
                }

                ZipFile.CreateFromDirectory(publishDirectory, zipFile);

                Console.WriteLine($"Published and zipped {profile}");
            }
        }
    }
#endif
}
