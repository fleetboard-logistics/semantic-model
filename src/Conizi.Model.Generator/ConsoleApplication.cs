using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Conizi.Model.Generator
{
    class ConsoleApplication
    {

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = typeof(ConsoleApplication).GetTypeInfo().Assembly.CodeBase;
                var uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        private readonly string[] args;
        private static IConfiguration _configuration;
        private ILogger<ConsoleApplication> logger;

        public ConsoleApplication(string[] args)
        {
            this.args = args;
         
        }

        internal void Init()
        {
            InitConfiguration();
  
            var consoleApp = new CommandLineApplication()
            {
                Name = Path.GetFileName(Assembly.GetEntryAssembly().GetName().CodeBase),
                Description = "Tool to generate JSON schemas for conizi models"
            };

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            consoleApp.HelpOption("-?|-h|--help");

            try
            {

                consoleApp.Command("list", command =>
                {
                    command.Description = "List all available conizi C# models";
                    command.HelpOption("-?|-h|--help");

                    command.OnExecute(() =>
                    {
                        
                        ListAllConiziModels();
                        return 0;
                    });
                });

                consoleApp.Command("generate", (command) =>
                {
                    command.Description = "Generate a conizi JSON schema from a C# model";
                    command.HelpOption("-?|-h|--help");

                    //var list = command.Option("-ls|--list", "List all available models", CommandOptionType.NoValue);
                    var all = command.Option("-a|--all", "Generate a schema for all available conizi models", CommandOptionType.NoValue);
                    var update = command.Option("-u|--update", "Update the the conizi models on the specified location", CommandOptionType.NoValue);
                    

                    command.OnExecute(() =>
                    {
                        try
                        {
                            if (all.HasValue())
                            {

                            }

                            var result = GenerateSchema();
                            Console.Write(result);
                            return 0;
                        }
                        catch (Exception ex)
                        {
                            logger.LogError(ex, "Error while generation schema for model {Model}", "model");
                            return 1;
                        }
                   
                    });
                });

                consoleApp.OnExecute(() =>
                {
                    Console.WriteLine("Usage: " + Path.GetFileName(Assembly.GetEntryAssembly().GetName().CodeBase) + " --help");
                    return 1;
                });

                consoleApp.Execute(args);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                logger.LogError(ex, "Error while running migration tool");
                Environment.Exit(1);
            }
        }

        private void InitConfiguration()
        {

            var hostBuilder = new HostBuilder()
                .ConfigureHostConfiguration(c =>
                {
                    c.SetBasePath(AppContext.BaseDirectory);
                    c.AddJsonFile("appsettings.json", optional: false);
                    c.AddEnvironmentVariables();
                })
                .ConfigureAppConfiguration((context, builder) => _configuration = context.Configuration)
                .ConfigureLogging((c, l) =>
                {
                    l.AddConfiguration(c.Configuration);
                    l.AddConsole(options => options.IncludeScopes = true);
                })
                .Build();

            logger = hostBuilder.Services.GetService<ILoggerFactory>().CreateLogger<ConsoleApplication>();

        }

        private bool ValidateInput(string source, string target)
        {
           

            return true;
        }


        private string GenerateSchema(bool all = false)
        {
            var generator = new Core.Generation.Generator();
            var generatorResult = generator.Generate<Manifest>();

            return null;
        }

        private List<Type> ListAllConiziModels()
        {
            var assembly = Assembly.LoadFrom(Path.Combine(AssemblyDirectory, "Conizi.Model.dll"));

            var schemas = assembly.GetTypes().Where(t =>
                t.CustomAttributes.Any(a => a.AttributeType == typeof(ConiziSchemaAttribute)));

            Console.WriteLine("Available Models:");
            Console.WriteLine();

            var types = new List<Type>();

            foreach (var schema in schemas)
            {
                var schemaAttribute = schema.GetCustomAttribute<ConiziSchemaAttribute>();
                var stringBuilder = new StringBuilder();
                
                stringBuilder.AppendLine($"Class: \t{schema.FullName}");
                stringBuilder.AppendLine($"Id: \t{schemaAttribute.Id}");
                stringBuilder.AppendLine($"File: \t{schemaAttribute.FileName}");
                stringBuilder.AppendLine("---");

                Console.Write(stringBuilder.ToString());

                types.Add(schema);
            }

            return types;
        }
    }
}
