using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Generation;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Conizi.Model.Core.Validate
{
    public class Validator
    {

        public static ConcurrentDictionary<string, EdiDocument> ModelCache = null;
        /// <summary>
        /// Register a JsonSchema License if available
        /// </summary>
        /// <param name="license"></param>
        public static void RegisterJsonSchemaLicense(string license)
        {
            License.RegisterLicense(license);
        }

        public static bool ValidateSchema<TModel>(string jsonMessage, out IList<string> validationErrors)
        {
            return ValidateSchema(typeof(TModel),jsonMessage, out validationErrors);
        }

        /// <summary>
        /// Validate assigned model vs the specific JSON Schema.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="jsonMessage">The message as IMessage</param>
        /// <param name="validationErrors">IList<string> of possible ValidationErrors</string></param>
        /// <returns>true/false</returns>
        public static bool ValidateSchema(Type model, string jsonMessage, out IList<string> validationErrors)
        {
            validationErrors = new List<string>();

            var content = jsonMessage;

            if (string.IsNullOrEmpty(content))
            {
                validationErrors = new List<string> {$"Message is empty!"};
                return false;
            }

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
                return valid;
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

                return false;
            }
        }
    }
}
