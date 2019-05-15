using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// A single Navigation between two partners. Usually used in a <see cref="T:Conizi.Model.Transport.Truck.Groupage.Forwarding.Tour" /> to extend the stops in a <see cref="T:Conizi.Model.Transport.Truck.Groupage.Forwarding.Tour" /> with necessary information for the navigation on the yard (last mile)
    /// </summary>
    [DisplayName("Yard-Navigation")]
    [Description("A single Yard Navigation which contains either an instruction or a status")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public class EdiYardNavigationInformation
    {
        /// <summary>
        /// Number which defines the sequence of the Navigation
        /// </summary>
        [Range(0, int.MaxValue)]
        [DisplayName("Position in the sequence")]
        [Description("Number which defines the position in the sequence of the instructions/status")]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Instruction with a checkpoint on the route that the driver has to follow.
        /// </summary>
        public EdiYardInstruction Instruction { get; set; }

        /// <summary>
        /// StatusCode that gets sent back when this position in the sequence is hit, usually with a <see cref="T:Conizi.Model.Transport.Truck.Groupage.Forwarding.TourEvent" />
        /// </summary>
        public EdiYardStatus Status { get; set; }
    }

    /// <summary>
    /// Status that gets sent back, usually with a <see cref="T:Conizi.Model.Transport.Truck.Groupage.Forwarding.Tour" />
    /// </summary>
    [DisplayName("Status")]
    [Description("Yard Status contains information that has so get sent back as part of a TourEvent")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public class EdiYardStatus
    {
        /// <summary>
        /// The actual StatusCode that gets sent back
        /// </summary>
        [Required]
        [DisplayName("StatusCode")]
        [Description("StatusCode that gets sent back")]
        public string StatusCode { get; set; }

        /// <summary>
        /// FreeText contains additional information for the status
        /// </summary>
        public EdiFreeText FreeText { get; set; }
    }

    /// <summary>
    /// An Instruction for the driver. Usually part of a <see cref="T:Conizi.Model.Shared.Entities.EdiYardNavigationInformation" />
    /// </summary>
    [DisplayName("Instruction for the driver")]
    [Description("Yard Instruction contains a Text Instruction and/or a Route with a gpx base64 file")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public class EdiYardInstruction
    {
        /// <summary>
        /// A Text Instruction to describe the driver specific instructions e.g. Report to Gate 4
        /// </summary>
        public EdiTextInstruction TextInstruction { get; set; }

        /// <summary>
        /// A Route that contains a gpx byte array and a destination
        /// </summary>
        public EdiGpxFile Route { get; set; }

        /// <summary>
        /// Urgency Code that can be used to signalize high-priority deliveries
        /// </summary>
        [DisplayName("Urgency Code")]
        [Description("Urgency Code that can be set to signalize high/low priority. Default is normal")]
        [DefaultValue(UrgencyCode.Normal)]
        public UrgencyCode? Urgency { get; set; }

        /// <summary>
        /// A Text Instruction to describe the driver specific instructions eg. Report to Gate 4. Usually part of a <see cref="T:Conizi.Model.Shared.Entities.EdiTextInstruction" />
        /// </summary>
        [DisplayName("A Text instruction for the driver")]
        [Description("A Text instruction for the driver ")]
        [ConiziAdditionalProperties(false)]
        [ConiziAllowXProperties(false)]
        public class EdiTextInstruction
        {
            /// <summary>
            /// Standard text that is used to fill predefined text-snippets
            /// </summary>
            public EdiStandardText StandardText { get; set; }

            /// <summary>
            /// FreeText that contains remarks (free form)
            /// </summary>
            public EdiFreeText FreeText { get; set; }

            /// <summary>
            /// The Address of a contact
            /// </summary>
            public EdiAddress Contact { get; set; }

            /// <summary>
            /// The ReportingPoint where the driver has to report on arrival 
            /// </summary>
            public List<EdiReportingPoint> ReportingPoints { get; set; }

            /// <summary>
            /// Attachments that can be added to the Instruction, can only contain references
            /// </summary>
            public List<EdiFileReference> Attachments { get; set; }
        }

        /// <summary>
        /// Reporting point, usually used in a <see cref="T:Conizi.Model.Shared.Entities.EdiTextInstruction" />
        /// </summary>
        [DisplayName("Reporting Point")]
        [Description("Reporting Point")]
        [ConiziAdditionalProperties(false)]
        [ConiziAllowXProperties(false)]
        public class EdiReportingPoint
        {
            /// <summary>
            /// Name of the Reporting Point
            /// </summary>
            [DisplayName("Reporting Point Name")]
            [Description("Name of the Reporting Point")]
            public string Name { get; set; }

            /// <summary>
            /// GeoPosition of the Reporting Point
            /// </summary>
            public EdiGeoPosition GeoPosition { get; set; }
        }

        /// <summary>
        /// Standard Text contains predefined Text snippets that can be filled with parameters
        /// </summary>
        [DisplayName("Standard Text with parameters")]
        [Description("Standard Text can be used to fill pre-defined text-snippets")]
        [ConiziAdditionalProperties(false)]
        [ConiziAllowXProperties(false)]
        public class EdiStandardText
        {
            /// <summary>
            /// Code for a specific text snippet
            /// </summary>
            [DisplayName("Code of the snippet")]
            [Description("Code for the specific snippet that shall be used for this standard Text e.g  001")]
            public string ContentCode { get; set; }

            /// <summary>
            /// Optional: The snippet with the filled in parameters if parameters can not be separated
            /// </summary>
            [DisplayName("Filled in snippet")]
            [Description("Filled in snippet, if parameters can not be separated")]
            public string FilledText { get; set; }

            /// <summary>
            /// Parameters which replace the placeholders in the called snippet
            /// </summary>
            [DisplayName("Parameters for a snippet")]
            [Description("Parameters that are filled in a pre-defined snippet. The Receiver has the snippet")]
            public List<string> Parameters { get; set; }
        }

        /// <summary>
        /// Gpx File for a route that contains multiple checkpoints and a destination
        /// </summary>
        [DisplayName("Gpx File Content")]
        [Description("Gpx File that contains checkpoints and a destination")]
        [ConiziAdditionalProperties(false)]
        [ConiziAllowXProperties(false)]
        public class EdiGpxFile
        {
            /// <summary>
            /// Data of the GpxFile as a byte-array
            /// </summary>
            [DisplayName("Gpx File Data")]
            [Description("Data of the Gpx-File")]
            public byte[] Data { get; set; }

            /// <summary>
            /// GeoPosition of the Destination Point of the route
            /// </summary>
            public EdiGeoPosition Destination { get; set; }
        }
    }

    /// <summary>
    /// Free Text with a optional category
    /// </summary>
    [DisplayName("remark (free form)")]
    [Description("remark (free form)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public class EdiFreeText
    {
        /// <summary>
        /// Category that the Content belongs to e.g. dangerous goods, special instructions, delivery condition
        /// </summary>
        [DisplayName("Qualifier for a Category")]
        [Description("Category that the Content belongs to e.g. dangerous goods, special instructions, delivery condition")]
        public string QualifierCode { get; set; }

        /// <summary>
        /// Language that the Content is written in, receiver needs to know the expression
        /// </summary>
        [DisplayName("Language Code")]
        [Description("Language Code for the Text")]
        public string Language { get; set; }

        /// <summary>
        /// The Content contains the actual message
        /// </summary>
        [DisplayName("Text Content")]
        [Description("Content contains the actual remark")]
        public string Content { get; set; }
    }


}
