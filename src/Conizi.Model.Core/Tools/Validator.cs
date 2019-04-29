using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Conizi.Model.Core.Entities;
using Conizi.Model.Core.Extensions;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Conizi.Model.Core.Tools
{
    /// <summary>
    /// The conizi schema validator is used to validate a JSON message against the assigned Schema.
    /// The validator is build around the C# library <see href="https://www.nuget.org/packages/Newtonsoft.Json.Schema/">Newtonsoft.Json.Schema</see>.
    /// </summary>
    /// <remarks>You can use this <see href="https://www.nuget.org/packages/Newtonsoft.Json.Schema/">Newtonsoft.Json.Schema</see> for free in a small context, to validate a huge amount of messages, you must buy a license.</remarks>
    public class Validator
    {

        /// <summary>
        /// Register a JsonSchema License if available
        /// </summary>
        /// <param name="license"><see href="https://www.nuget.org/packages/Newtonsoft.Json.Schema/">Newtonsoft.Json.Schema</see> license as string</param>
        public static void RegisterJsonSchemaLicense(string license)
        {
            License.RegisterLicense(license);
        }
        
        /// <summary>
        /// Parse the JSON message and try to extract the model
        /// </summary>
        /// <param name="jsonMessage">JSON message as string</param>
        /// <returns>Type of the used model/class</returns>
        /// <exception cref="InvalidOperationException"></exception>
        private static Type ParseModel(string jsonMessage)
        {
            var jModel = JObject.Parse(jsonMessage);

            var mProperty = jModel.Property("$schema");

            if (mProperty == null)
                throw new InvalidOperationException("Message has no schema tag!");

            var modelString = mProperty.Value.Value<string>();

            modelString = modelString.Contains(".json") ? modelString : modelString + ".json";

            var model = Helper.GetConiziModel(modelString);

            if (model == null)
                throw new InvalidOperationException("Model is not available!");

            return model;
        }

        /// <summary>
        /// Validate a JSON message vs the specific JSON Schema. The method tries to extract the schema from the message.
        /// </summary>
        /// <param name="jsonMessage">JSON message as string</param>
        /// <param name="validationErrors">Possible validation errors as list of strings</param>
        /// <returns><see cref="ValidationResult"/></returns>
        public static ValidationResult ValidateSchema(string jsonMessage, out IList<string> validationErrors)
        {
           return ValidateSchema(ParseModel(jsonMessage), jsonMessage, out validationErrors);
        }

        /// <summary>
        /// Validate a JSON message vs the specific JSON Schema by type.
        /// </summary>
        /// <param name="jsonMessage">JSON message as string</param>
        /// <param name="validationErrors">Possible validation errors as list of strings</param>
        /// <returns><see cref="ValidationResult"/></returns>
        public static ValidationResult ValidateSchema<TModel>(string jsonMessage, out IList<string> validationErrors)
        {
            return ValidateSchema(typeof(TModel),jsonMessage, out validationErrors);
        }

        /// <summary>
        /// Validate a JSON message vs the specific JSON Schema.
        /// </summary>
        /// <param name="model">Type of the used C# model</param>
        /// <param name="jsonMessage">JSON message as string</param>
        /// <param name="validationErrors">Possible validation errors as list of strings</param>
        /// <returns><see cref="ValidationResult"/></returns>
        public static ValidationResult ValidateSchema(Type model, string jsonMessage, out IList<string> validationErrors)
        {
            validationErrors = new List<string>();
            var result = new ValidationResult();

            var content = jsonMessage;

            if (string.IsNullOrEmpty(content))
                return result.CreateError("Message is empty!", model);
            
            try
            {
                var generatorResult = Generator.Generate(model);

                var settings = new JSchemaReaderSettings
                {
                    ValidateVersion = true
                };

                var schema = JSchema.Parse(generatorResult.JSchema.ToString(SchemaVersion.Draft6), settings);
                var messageObject = JObject.Parse(content);
                var valid = messageObject.IsValid(schema, out validationErrors);
                return valid ? result.CreateSuccess(schema, model) : result.CreateError(validationErrors, model, schema);
            }
            catch (Exception ex)
            {
                validationErrors.Add($"Schema Validation Error: Schema may be invalid for model {nameof(model)}");
                validationErrors.Add(ex.Message);
                var error = ex;
                while (error.InnerException != null)
                {
                    error = error.InnerException;
                    validationErrors.Add(error.Message);
                }

                return result;
            }
        }
    }
}
