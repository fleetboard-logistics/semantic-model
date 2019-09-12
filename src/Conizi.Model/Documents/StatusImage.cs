using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;

namespace Conizi.Model.Documents
{
    /// <summary>
    /// A status image is a kind of document to document a process
    /// </summary>
    [DisplayName("Status Image")]
    [Description("A status image is a kind of document to document a process")]
    [ConiziSchema("https://model.conizi.io/v1/documents/status-image.json", "status-image.json")]
    public class StatusImage : EdiDocument
    {
        /// <summary>
        /// A list of status images
        /// </summary>
        [Required]
        public List<EdiStatusImage> Images { get; set; }
    }
}
