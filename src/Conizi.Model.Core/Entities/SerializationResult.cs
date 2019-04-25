using System;
using System.Collections.Generic;
using System.Text;

namespace Conizi.Model.Core.Entities
{
    /// <summary>
    /// The result object of a serialization by the converter
    /// <inheritdoc cref="ConverterResult"/>
    /// </summary>
    public class SerializationResult :ConverterResult
    {
        /// <summary>
        /// The instance of the model was validated during processing
        /// </summary>
        public bool IsValidated { get; internal set; }

        /// <summary>
        /// Get the content as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Content;
        }
    }
}
