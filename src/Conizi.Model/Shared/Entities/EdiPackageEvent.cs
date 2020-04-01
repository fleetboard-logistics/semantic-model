using System;
using System.ComponentModel;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// Event to notify about package specific incidents
    /// </summary>
    [DisplayName("Package specific Event")]
    [Description("Event to notify about package specific incidents")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    
    public class EdiPackageEvent : EdiEventBase
    {
        /// <summary>
        /// Type of the package that is being reported
        /// </summary>
        [DisplayName("Type of the package")]
        [Description("Type of the package that is beeing reported")]
        public string PackageType { get; set; }

        /// <summary>
        /// Master barcode (i.e. Master colli)
        /// </summary>
        [DisplayName("Master barcode")]
        [Description("Master barcode (i.e. Master colli)")]
        public string MasterBarcode { get; set; }

        /// <summary>
        /// Lot number
        /// </summary>
        [DisplayName("Lot number")]
        [Description("Lot number")]
        public string LotNo { get; set; }

        /// <summary>
        /// Best before date
        /// </summary>
        [DisplayName("Best before")]
        [Description("Best before")]
        public DateTime? BestBeforeDate { get; set; }

        /// <summary>
        /// Transport Unit Number
        /// </summary>
        [DisplayName("Transport Unit Number")]
        [Description("Transport Unit Number")]
        public string TransportUnitNo { get; set; }

        /// <summary>
        /// Scan user
        /// </summary>
        [DisplayName("Scan user")]
        [Description("Scan user")]
        public string ScanUser { get; set; }

        /// <summary>
        /// Gate
        /// </summary>
        [DisplayName("Gate")]
        [Description("Gate")]
        public string GateNo { get; set; }

        /// <summary>
        /// Terminal number
        /// </summary>
        [DisplayName("Terminal number")]
        [Description("Terminal number")]
        public string TerminalNo { get; set; }

        /// <summary>
        /// Bulkiness of the package
        /// </summary>
        public EdiPackageBulkiness Bulkiness { get; set; }

        /// <summary>
        /// Package Bulkiness category
        /// </summary>
        [DisplayName("Bulkiness category")]
        [Description("Bulkiness category")]
        public string BulkinessCategory{ get; set; }

        /// <summary>
        /// Detailed information about the exceptions that occured while processing / scanning the package
        /// </summary>
        public EdiPackageEventExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// EdiPackageBulkiness of the package (length / width / height)
    /// </summary>
    [DisplayName("Bulkiness of the package")]
    [Description("Bulkiness of the package (length / width / height)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    
    public class EdiPackageBulkiness : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Length in meter
        /// </summary>
        [DisplayName("Length (m)")]
        [Description("Length in meter")]
        public decimal? Length { get; set; }

        /// <summary>
        /// Width in meter
        /// </summary>
        [DisplayName("Width (m)")]
        [Description("Width in meter")]
        public decimal? Width { get; set; }

        /// <summary>
        /// Height in meter
        /// </summary>
        [DisplayName("Height (m)")]
        [Description("Height in meter")]
        public decimal? Height { get; set; }

    }

    /// <summary>
    /// Detailed information about the exceptions that occured while processing / scanning the package
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while processing / scanning the package")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    
    public class EdiPackageEventExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The package is damaged
        /// </summary>
        //[DisplayName("Damaged")]
        //[Description("The package is demaged")]
        public EdiEmptyExtendableObject Damaged { get; set; }

        /// <summary>
        /// The package is pressed in
        /// </summary>
        //[DisplayName("Pressed in")]
        //[Description("The package is pressed in")]
        public EdiEmptyExtendableObject PressedIn { get; set; }

        /// <summary>
        /// The package is open, the goods are pick-able
        /// </summary>
        //[DisplayName("Open")]
        //[Description("The package is open, the goods are pick-able")]
        public EdiEmptyExtendableObject Open { get; set; }

        /// <summary>
        /// The package is wet
        /// </summary>
        //[DisplayName("Wet")]
        //[Description("The package is wet")]
        public EdiEmptyExtendableObject Wet { get; set; }

        /// <summary>
        /// The content of the package is running out
        /// </summary>
        //[DisplayName("Package leaked, content is running out")]
        //[Description("The content of the package is running out")]
        public EdiEmptyExtendableObject Leaked { get; set; }

        /// <summary>
        /// The package was rejected by the receiver
        /// </summary>
        //[DisplayName("Rejected")]
        //[Description("The package was rejected by the receiver")]
        public EdiEmptyExtendableObject Rejected { get; set; }

        /// <summary>
        /// The content is damaged after the removal of the packaging
        /// </summary>
        //[DisplayName("Damaged after packaging removal")]
        //[Description("The content is damaged after the removal of the packaging")]
        public EdiEmptyExtendableObject DamagedAfterPackagingRemoval { get; set; }

        /// <summary>
        /// The goods could not be checked, because packaging is shrink-wrapped
        /// </summary>
        //[DisplayName("Packaging is shrink-wrapped")]
        //[Description("The goods could not be checked, because packaging is shrink-wrapped")]
        public EdiEmptyExtendableObject ShrinkWrapped { get; set; }

        /// <summary>
        /// The empties are damaged, but content OK
        /// </summary>
        //[DisplayName("Empties damaged content OK")]
        //[Description("The empties are damaged, but content OK")]
        public EdiEmptyExtendableObject DamagedEmptiesContentOk { get; set; }


        /// <summary>
        /// The package is oversized
        /// </summary>
        //[DisplayName("Oversized)]
        //[Description("The package is oversized")]
        public EdiEmptyExtendableObject Oversized { get; set; }

        /// <summary>
        /// It's a special run
        /// </summary>
        //[DisplayName("Special run")]
        //[Description("It's a special trip")]
        public EdiEmptyExtendableObject SpecialRun { get; set; }

        /// <summary>
        /// Not enough space
        /// </summary>
        //[DisplayName("Space issue")]
        //[Description("Space issue, not enough space")]
        public EdiEmptyExtendableObject SpaceIssue { get; set; }

        /// <summary>
        /// Time issue, not enough time
        /// </summary>
        //[DisplayName("Time issue")]
        //[Description("Time issue, not enough time")]
        public EdiEmptyExtendableObject TimeIssue { get; set; }

        /// <summary>
        /// Error when routing the package
        /// </summary>
        //[DisplayName("Routing error")]
        //[Description("Error when routing the package")]
        public EdiEmptyExtendableObject RoutingError { get; set; }

        /// <summary>
        /// Error when loading the package
        /// </summary>
        //[DisplayName("Loading error")]
        //[Description("Error when loading the package")]
        public EdiEmptyExtendableObject LoadingError { get; set; }

        /// <summary>
        /// The package was lost
        /// </summary>
        //[DisplayName("Lost")]
        //[Description("The package was lost")]
        public EdiEmptyExtendableObject Lost { get; set; }
    }
}
