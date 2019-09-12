using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;

namespace Conizi.Model.Documents
{
    /// <summary>
    /// A transport document is a kind of document used to convey information about cargo that is being transported
    /// </summary>
    [DisplayName("Transport Document")]
    [Description("A transport document is a kind of document used to convey information about cargo that is being transported")]
    [ConiziSchema("https://model.conizi.io/v1/documents/transport-document.json", "transport-document.json")]
    public class TransportDocument : EdiDocument
    {
        /// <summary>
        /// A list of document items
        /// </summary>
        [Required]
        public List<EdiDocumentItem> Documents { get; set; }
    }
}
