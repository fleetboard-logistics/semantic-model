using System;
using System.IO;
using Conizi.Model.Tooling.Generate;

namespace Conizi.Model.Tooling
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: dotnet Conizi.Model.Tooling.exe [path to models]");
                Environment.ExitCode = 1;
                return;
            }

            if (!Directory.Exists(args[0]))
            {
                Console.WriteLine($"Directory '{args[0]}' does not exists!");
                Environment.ExitCode = 1;
                return;
            }
            
            Console.WriteLine("Generating models with base path " + args[0]);

            Environment.ExitCode = GenerateModels.Generate(args[0]) ? 0 : 1;
        }
    }
}
