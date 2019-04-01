using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Entities;
using Conizi.Model.Core.Extensions;
using Conizi.Model.Core.Generation;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Conizi.Model.Core.Validate
{
    public class Validator
    {

        public static ConcurrentDictionary<string, EdiModel> ModelCache = null;
        /// <summary>
        /// Register a JsonSchema License if available
        /// </summary>
        /// <param name="license"></param>
        public static void RegisterJsonSchemaLicense(string license)
        {
            License.RegisterLicense(license);
        }

        private static Type ParseModel(string jsonMessage)
        {
            var jModel = JObject.Parse(jsonMessage);

            var mProperty = jModel.Property("$schema");

            if (mProperty == null)
                throw new InvalidOperationException("Message has no schema tag!");

            var modelString = mProperty.Value.Value<string>();

            var model = Helper.GetConiziModel(modelString);

            if (model == null)
                throw new InvalidOperationException("Model is not available!");

            return model;
        }

        public static ValidationResult ValidateSchema(string jsonMessage, out IList<string> validationErrors)
        {
           return ValidateSchema(ParseModel(jsonMessage), jsonMessage, out validationErrors);
        }

        public static ValidationResult ValidateSchema<TModel>(string jsonMessage, out IList<string> validationErrors)
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
