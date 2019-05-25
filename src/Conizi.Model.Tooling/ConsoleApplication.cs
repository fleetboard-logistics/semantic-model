using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading;
using Conizi.Model.Core;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Schema;
using Validator = Conizi.Model.Core.Tools.Validator;

namespace Conizi.Model.Generator
{
    class ConsoleApplication
    {

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

                consoleApp.Command("validate", command =>
                {
                    command.Description = "Validate a message vs the associated model";
                    command.HelpOption("-?|-h|--help");

                    var model = command.Option("-m|--model", "Specify the model that should be used to validate the message", CommandOptionType.SingleValue);
                    var file = command.Option("-f|--file", "Specify the path to the json message file", CommandOptionType.SingleValue);


                    command.OnExecute(() =>
                    {
                        var selectedModel = default(Type);

                        if (model.HasValue())
                        {
                            selectedModel = Helper.GetConiziModels().FirstOrDefault(m => m.FullName.Contains(model.Value()));

                            if (selectedModel == null)
                            {
                                logger.LogError("Model {Model} could not be found!", model.Value());
                                return 1;
                            }

                            Console.WriteLine($"Using Model: {selectedModel.FullName}");
                        }

                        if (file.HasValue())
                        {
                            
                            if (!File.Exists(file.Value()))
                            {
                                logger.LogError("File {File} could not be found!","sfs");
                                return 1;
                            }
                        
                            Console.WriteLine($"Using File: {file.Value()}");
                        }
                        Console.WriteLine("Validating...");
                        if(this.ValidateInput(selectedModel,File.ReadAllText(file.Value())))
                        {
                            Console.WriteLine("Model is valid");
                            return 0;
                        }
                        Console.WriteLine("Model is invalid!");
                        return 1;
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
                Thread.Sleep(500);
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

        #region Doing


        private bool ValidateInput(Type model, string json)
        {
            if(Validator.ValidateSchema(model,json, out var  validationErrors).IsValid)
                return true;
            

            foreach(var error in validationErrors) {
                Console.WriteLine(error);
            }

            return false;
        }


        private string GenerateSchema(bool all = false)
        {
            //var generator = new Core.Generation.Generator();
            //var generatorResult = generator.Generate<Manifest>();

            //return generatorResult.JSchema.ToString(SchemaVersion.Draft6);

            return null;
        }

        private List<Type> ListAllConiziModels()
        {
            var schemas = Helper.GetConiziModels();

            foreach (var schema in schemas)
            {
                var schemaAttribute = schema.GetCustomAttribute<ConiziSchemaAttribute>();
                var stringBuilder = new StringBuilder();
                
                stringBuilder.AppendLine($"Class: \t{schema.FullName}");
                stringBuilder.AppendLine($"Id: \t{schemaAttribute.Id}");
                stringBuilder.AppendLine($"File: \t{schemaAttribute.FileName}");
                stringBuilder.AppendLine("---");

                Console.Write(stringBuilder.ToString());
            }

            return schemas.ToList();
        }

        #endregion
    }
}
