using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Object to transmit file attachments
    /// </summary>
    [DisplayName("File Attachment")]
    [Description("Object to transmit file attachments")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiFileAttachment : EdiEventBase
    {
        /// <summary>
        /// Attached documents regarding an event (Like POD, …)
        /// </summary>
        public List<EdiDocumentItem>  Documents { get; set; }

        /// <summary>
        /// Attached images regarding an event (like damage pictures, …)
        /// </summary>
        public List<EdiStatusImage> Images { get; set; }
    }
}