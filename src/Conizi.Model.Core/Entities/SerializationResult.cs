using System;
using System.Collections.Generic;
using System.Text;

namespace Conizi.Model.Core.Entities
{
     public class SerializationResult :ConverterResult
    {
        public bool IsValidated { get; internal set; }

        public override string ToString()
        {
            return this.Content;
        }
    }
}
