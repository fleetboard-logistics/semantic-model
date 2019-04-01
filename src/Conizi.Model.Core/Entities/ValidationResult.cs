using System;
using System.Collections.Generic;
using System.Text;

namespace Conizi.Model.Core.Entities
{
     public class ValidationResult : ConverterResult
    {
        /// <summary>
        /// The validation of the model was successful
        /// </summary>
        public bool IsValid { get; set; }

        public override string ToString()
        {
            return this.Schema;
        }
    }
}
