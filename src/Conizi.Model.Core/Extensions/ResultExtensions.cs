using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Entities;
using Newtonsoft.Json.Schema;

namespace Conizi.Model.Core.Extensions
{
    /// <summary>
    /// Extension to create validation results in an easy way
    /// </summary>
    public static class ResultExtensions
    {
        /// <summary>
        /// Create an error validation result
        /// </summary>
        /// <param name="result">Instance of the ValidationResult</param>
        /// <param name="message">The message should be set</param>
        /// <param name="model">The model type should be set</param>
        /// <param name="schema">The schema should be set</param>
        /// <param name="file">The file was validated</param>
        /// <returns><see cref="ValidationResult"/></returns>
        public static ValidationResult CreateError(this ValidationResult result, string message, Type model = null, JSchema schema=null, string file = null)
        {
            return CreateError(result, new List<string> { message }, model,schema, file);
        }

        /// <summary>
        /// Create an error validation result
        /// </summary>
        /// <param name="result">Instance of the ValidationResult</param>
        /// <param name="errorMessages">A list of error messages should be set</param>
        /// <param name="model">The model type should be set</param>
        /// <param name="schema">The schema should be set</param>
        /// <param name="file">The file was validated</param>
        /// <returns><see cref="ValidationResult"/></returns>
        public static ValidationResult CreateError(this ValidationResult result, IList<string> errorMessages, Type model, JSchema schema = null, string file = null)
        {
            result.IsValid = false;
            result.File = file;
            result.Model = model;
            result.ValidationErrors = errorMessages;
            result.Schema = schema?.ToString(SchemaVersion.Draft6);
            return result;
        }

        /// <summary>
        /// Create a successful validation result
        /// </summary>
        /// <param name="result">Instance of the ValidationResult</param>
        /// <param name="model">The model type should be set</param>
        /// <param name="schema">The schema should be set</param>
        /// <param name="file">The file was validated</param>
        /// <returns><see cref="ValidationResult"/></returns>
        public static ValidationResult CreateSuccess(this ValidationResult result, JSchema schema, Type model, string file = null)
        {
            result.IsValid = true;
            result.File = file;
            result.Model = model;
            result.Schema = schema.ToString(SchemaVersion.Draft6);
            return result;
        }
    }
}
