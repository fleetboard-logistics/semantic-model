using Conizi.Model.Core.Tools;

namespace Conizi.Model.Core.Entities
{
    /// <summary>
    /// The result object of a serialization by the <see cref="Converter"/>
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
