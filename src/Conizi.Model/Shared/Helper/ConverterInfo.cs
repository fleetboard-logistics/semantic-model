using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Helper
{
    
    [DisplayName("Converter info")]
    [Description("conizi internal information about the converter process")]
    [ConiziAdditionalProperties(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class ConverterInfo
    {
        [DisplayName("Original format")]
        [Description("The original format like FORTRAS...")]
        public string OriginalFormat { get; set; }

        [DisplayName("Original codelist")]
        [Description("The original code list like SYA, SAE...")]
        public string OriginalCodelist { get; set; }

        [DisplayName("Converter version")]
        [Description("The version string of the converter")]
        public string ConverterVersion { get; set; }

        [DisplayName("Converter name")]
        [Description("The name of the used converter")]
        public string ConverterName { get; set; }

        [DisplayName("Conversion date")]
        [Description("The date of conversion")]
        public DateTime? ConversionDate { get; set; }
    }
}