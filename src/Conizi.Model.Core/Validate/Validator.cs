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
        private static JSchemaPreloadedResolver _resolver = null;

        
        static Validator()
        {
            //License.RegisterLicense(_newtonsoftLicense);
        }

        /// <summary>
        /// Validate assigned model vs the specific JSON Schema.
        /// </summary>
        /// <param name="jsonMessage">The message as IMessage</param>
        /// <param name="validationErrors">IList<string> of possible ValidationErrors</string></param>
        /// <returns>true/false</returns>
        public static bool ValidateSchema<TModel>(string jsonMessage, out IList<string> validationErrors)
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
                var generator = new Generator();
                var generatorResult = generator.Generate<TModel>();

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
                validationErrors.Add($"Schema Validation Error: Schema may be invalid for model {nameof(TModel)}");
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
