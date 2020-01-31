using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Event to notify about tour specific documents
    /// </summary>
    [DisplayName("Tour Documents")]
    [Description("Event to notify about tour specific documents")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    
    public class EdiTourDocuments : EdiTourEventBase
    {
        /// <summary>
        /// Pictures/Files of signee's signature
        /// </summary>
        public List<EdiFileContent> Signature { get; set; }

        /// <summary>
        /// Pictures/Files of damages
        /// </summary>
        public List<EdiFileContent> Damages { get; set; }

        /// <summary>
        /// Pictures/Files of load securing
        /// </summary>
        public List<EdiFileContent> LoadSecuring { get; set; }

        /// <summary>
        /// Pictures/Files of driving license
        /// </summary>
        public List<EdiFileContent> DrivingLicense { get; set; }

        /// <summary>
        /// Checklist of departure control available
        /// </summary>
        [DisplayName("Checklist Departure Control")]
        [Description("A checklist of departure control is available")]
        public bool? ChecklistDepartureControl { get; set; }

        /// <summary>
        /// Checklist of instructions available
        /// </summary>
        [DisplayName("Checklist Instruction")]
        [Description("A checklist of vehicle inspection is available")]
        public bool? ChecklistInstruction{ get; set; }

        /// <summary>
        /// Checklist of vehicle inspection available
        /// </summary>
        [DisplayName("ChecklistVehicle Inspection")]
        [Description("A checklist of vehicle inspection is available")]
        public bool? ChecklistVehicleInspection { get; set; }

        /// <summary>
        /// A list of further document items
        /// </summary>
        public List<EdiDocumentItem> OtherDocuments { get; set; }

        /// <summary>
        /// A list of status images
        /// </summary>
        public List<EdiStatusImage> OtherImages { get; set; }
    }
}