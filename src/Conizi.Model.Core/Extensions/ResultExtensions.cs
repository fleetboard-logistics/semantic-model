using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Entities;
using Newtonsoft.Json.Schema;

namespace Conizi.Model.Core.Extensions
{
    public static class ResultExtensions
    {
        public static ValidationResult CreateError(this ValidationResult result, string message, Type model = null, JSchema schema=null, string file = null)
        {
            return CreateError(result, new List<string> { message }, model,schema, file);
        }

        public static ValidationResult CreateError(this ValidationResult result, IList<string> errorMessages, Type model, JSchema schema = null, string file = null)
        {
            result.IsValid = false;
            result.File = file;
            result.Model = model;
            result.ValidationErrors = errorMessages;
            result.Schema = schema?.ToString(SchemaVersion.Draft6);
            return result;
        }


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
