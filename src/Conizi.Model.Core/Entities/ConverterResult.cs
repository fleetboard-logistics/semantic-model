using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Conizi.Model.Core.Entities
{
    /// <summary>
    /// The base result class for converter related stuff.
    /// </summary>
    public abstract class ConverterResult
    {
        private IList<string> validationErrors = new List<string>();

        /// <summary>
        /// A list of validation errors
        /// </summary>
        public IList<string> ValidationErrors
        {
            get => this.validationErrors;
            internal set
            {
                this.validationErrors = value;
                this.HasValidationErrors = true;
            }
        }

        /// <summary>
        /// The type of the model was used during the processing
        /// </summary>
        public Type Model { get; set; }

        /// <summary>
        /// Validation errors available
        /// </summary>
        public bool HasValidationErrors { get; private set; }

        /// <summary>
        /// The content/result of the operation as string
        /// </summary>
        [JsonIgnore] public string Content { get; set; }

        /// <summary>
        /// The JSON definition of the involved schema
        /// </summary>
        [JsonIgnore] public string Schema { get; set; }

        /// <summary>
        /// Filename or path of file was processed
        /// </summary>
        public string File { get; set; }
    }
}