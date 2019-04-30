using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Tools;

namespace Conizi.Model.Core.Entities
{
    /// <summary>
    /// The result object of validation by the <see cref="Validator"/>
    /// </summary>
     public class ValidationResult : ConverterResult
    {
        /// <summary>
        /// The validation of the model was successful
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// The schema content as string
        /// </summary>
        /// <returns>JSON schema as string</returns>
        public override string ToString()
        {
            return this.Schema;
        }
    }
}
