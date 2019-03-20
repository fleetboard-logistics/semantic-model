using System;
using System.Collections.Generic;
using System.Text;

namespace Conizi.Model.Core.Entities
{
     public class ConversionResult
    {
        private IList<string> validationErrors;

        public IList<string> ValidationErrors
        {
            get => this.validationErrors;
            internal set
            {
                this.validationErrors = value;
                this.HasValidationErrors = true;
            }
        }

        public bool HasValidationErrors { get; private set; }

        public string Content { get; set; }

        public bool IsValidated { get; internal set; }
    }
}
