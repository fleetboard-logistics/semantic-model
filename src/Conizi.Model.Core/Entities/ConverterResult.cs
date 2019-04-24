using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Conizi.Model.Core.Entities
{
     public abstract class ConverterResult
     {
         private IList<string> validationErrors = new List<string>();

        public IList<string> ValidationErrors
        {
            get => this.validationErrors;
            internal set
            {
                this.validationErrors = value;
                this.HasValidationErrors = true;
            }
        }

        public Type Model { get; set; }

        public bool HasValidationErrors { get; private set; }

        [JsonIgnore]
        public string Content { get; set; }

        [JsonIgnore]
        public string Schema { get; set; }

        /// <summary>
        /// Filename or path of file was processed
        /// </summary>
        public string File { get; set; }


    }
}
