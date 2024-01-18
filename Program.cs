using Newtonsoft.Json;
using System;
using System.IO;

namespace KoRegex
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
#if PUBLISH
            new Publish(args);
#else
      new Start(args);
#endif

        }
    }
}
