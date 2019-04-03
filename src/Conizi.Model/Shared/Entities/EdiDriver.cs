using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("driver")]
    [DisplayName("Driver")]
    [Description("Information about the drivers of the vehicles")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDriver
    {
        [DisplayName("Diver Id")]
        [Description("The id of the driver")]
        public string DriverId { get; set; }

        [DisplayName("Name of the driver")]
        [Description("The name of the driver")]
        public string Name { get; set; }

        [DisplayName("Phone number")]
        [Description("The phone number of the driver")]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}