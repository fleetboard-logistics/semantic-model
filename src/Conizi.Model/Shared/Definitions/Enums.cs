using Conizi.Model.Shared.Attributes;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Conizi.Model.Shared.Definitions
{
  /// <summary>
  /// Determines how the current message should be handled, e.g. whether the stops / consignments should be added removed, ...
  /// </summary>
  [Description(
      "Determines how the current message should be handled, e.g. whether the stops / consignments should be added removed, ...")]
  [ConiziAdditionalProperties(false)]
  public enum EdiMessageFunctionCode
  {
    /// <summary>
    /// Add a new tour
    /// </summary>
    [EnumMember(Value = "add")] Add = 1,

    /// <summary>
    /// Update a tour
    /// </summary>
    [EnumMember(Value = "update")] Update = 2,

    /// <summary>
    /// Remove a tour
    /// </summary>
    [EnumMember(Value = "remove")] Remove = 3,

    /// <summary>
    /// Add a part of a tour
    /// </summary>
    [EnumMember(Value = "add_partial")] AddPartial = 11,

    /// <summary>
    /// Update a part of a tour
    /// </summary>
    [EnumMember(Value = "update_partial")] UpdatePartial = 12,

    /// <summary>
    /// Remove a part of a tour
    /// </summary>
    [EnumMember(Value = "remove_partial")] RemovePartial = 13
  }

  /// <summary>
  /// Determines the unit in which a given property is measured
  /// Default kilometers per hour
  /// </summary>
  [Description("Determines the unit of a given property. Default kilometers per hour")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties(false)]
  public enum MeasurementUnitCode
  {
    /// <summary>
    /// Values are measured in kilometers / Speed in Kilometers per Hour
    /// </summary>
    [Description("Distance Values are measured in kilometers / Speed in Kilometers per Hour")]
    [EnumMember(Value = "KMT")]
    Kilometer,

    /// <summary>
    /// Values are measured in nautical miles / Speed in nautical miles per Hour
    /// </summary>
    [Description("Distance Values are measured in nautical miles")]
    [EnumMember(Value = "NMI")]
    NauticalMile,

    /// <summary>
    /// Values are measured in miles / Speed in miles per Hour
    /// </summary>
    [Description("Distance Values are measured in (Statute/English) miles / Speed in miles per Hour")]
    [EnumMember(Value = "SMI")]
    StatuteMile
  }

  /// <summary>
  /// Determines a priority of a given message
  /// </summary>
  [Description("Determines a priority of a given message")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties(false)]
  public enum UrgencyCode
  {
    /// <summary>
    /// Describes a normal priority
    /// </summary>
    [Description("Message has a normal priority")]
    [EnumMember(Value = "normal")]
    Normal,

    /// <summary>
    /// Describes a high priority
    /// </summary>
    [Description("Message has a high priority")]
    [EnumMember(Value = "high")]
    High,

    /// <summary>
    /// Describes a low priority
    /// </summary>
    [Description("Message has a low priority")]
    [EnumMember(Value = "low")]
    Low,
  }

  /// <summary>
  /// Types of loading equipment
  /// </summary>
  [Description("Types of loading equipment")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties(false)]
  public enum LoadingEquipmentType
  {
    /// <summary>
    /// Unknown loading equipment
    /// </summary>
    [Description("Unknown loading equipment")]
    [EnumMember(Value = "unknown")]
    Unknown = 0,

    /// <summary>
    /// EUR Pallets as defined by European Pallet Association (EPAL)
    /// </summary>
    [Description("EUR Pallets as defined by European Pallet Association (EPAL)")]
    [EnumMember(Value = "eurPallets")]
    EurPallets = 1,

    /// <summary>
    /// EUR Boxes as defined by European Pallet Association (EPAL)
    /// </summary>
    [Description("EUR Boxes as defined by European Pallet Association (EPAL)")]
    [EnumMember(Value = "eurBoxes")]
    EurBoxes = 2,

    /// <summary>
    /// H1 Pallets
    /// </summary>
    [Description("H1 Pallets")]
    [EnumMember(Value = "h1Pallets")]
    H1Pallets = 3,

    /// <summary>
    /// E2 Pallets
    /// </summary>
    [Description("E2 Pallets")]
    [EnumMember(Value = "e2Pallets")]
    E2Pallets = 4,

    /// <summary>
    /// OneWayPallets like Chep pallets
    /// </summary>
    [Description("OneWayPallets like Chep pallets")]
    [EnumMember(Value = "oneWayPallets")]
    OneWayPallets = 5,

    /// <summary>
    /// Knauf Pallets
    /// </summary>
    [Description("Knauf Pallets")]
    [EnumMember(Value = "knaufPallets")]
    KnaufPallets = 6,

    /// <summary>
    /// Düsseldorfer Pallets
    /// </summary>
    [Description("Düsseldorfer Pallets")]
    [EnumMember(Value = "duesseldorferPallets")]
    DuesseldorferPallets = 7,

    /// <summary>
    /// Düsseldorfer plastic Pallets
    /// </summary>
    [Description("Düsseldorfer plastic Pallets")]
    [EnumMember(Value = "kdp")]
    Kdp = 8,

    /// <summary>
    /// Intermediate bulk containers
    /// </summary>
    [Description("Intermediate bulk containers")]
    [EnumMember(Value = "ibc")]
    Ibc = 9,

    /// <summary>
    /// E2 Pallets
    /// </summary>
    [Description("E3 Pallets")]
    [EnumMember(Value = "e3Pallets")]
    E3Pallets = 10,

    /// <summary>
    /// Chemical pallets
    /// </summary>
    [Description("Chemical pallets")]
    [EnumMember(Value = "chemicalPallets")]
    Cp = 11,

    /// <summary>
    /// CHEP pallets
    /// </summary>
    [Description("CHEP pallets")]
    [EnumMember(Value = "chep")]
    Chep = 12,

    /// <summary>
    /// CC-Container
    /// </summary>
    [Description("CC-Container")]
    [EnumMember(Value = "cc")]
    Cc = 13,

    /// <summary>
    /// Lattice box
    /// </summary>
    [Description("Lattice box")]
    [EnumMember(Value = "gp")]
    Gp = 14,

    /// <summary>
    /// Custom Loading Equipment, for custom boxes, pallets and other equipment
    /// </summary>
    [Description("Custom Loading Equipment")]
    [EnumMember(Value = "customLoadingEquipment")]
    CustomLoadingEquipment = 99,
  }


  /// <summary>
  /// Types of loading unites
  /// </summary>
  [Description("Types of loading unites")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties(false)]
  public enum LoadingUnitType
  {
    /// <summary>
    /// A swap body
    /// </summary>
    [Description("A swap body")]
    [EnumMember(Value = "swapBody")]
    SwapBody = 1,

    /// <summary>
    /// A container
    /// </summary>
    [Description("A container)")]
    [EnumMember(Value = "container")]
    Container = 2,

    /// <summary>
    /// A frame
    /// </summary>
    [Description("A frame")]
    [EnumMember(Value = "frame")]
    Frame = 3,

    /// <summary>
    /// A silo for concrete, etc...
    /// </summary>
    [Description("A silo for concrete, etc...")]
    [EnumMember(Value = "silo")]
    Silo = 4,

    /// <summary>
    /// A tank for liquids
    /// </summary>
    [Description("A tank for liquids")]
    [EnumMember(Value = "tank")]
    Tank = 5,

    /// <summary>
    /// Custom Loading Unit, for custom containers, tanks and other equipment
    /// </summary>
    [Description("Custom Loading Unit")]
    [EnumMember(Value = "customLoadingUnit")]
    CustomLoadingUnit = 99,
  }

  /// <summary>
  /// Types of different stops
  /// </summary>
  [Description("Types of different stops")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties(false)]
  public enum StopType
  {
    /// <summary>
    /// A Unknown Stop
    /// </summary>
    [Description("A Unknown Stop")]
    [EnumMember(Value = "unknown")]
    Unknown = 0,

    /// <summary>
    /// A Loading Stop
    /// </summary>
    [Description("A Loading Stop")]
    [EnumMember(Value = "loading")]
    Loading = 1,

    /// <summary>
    /// An Unloading Stop
    /// </summary>
    [Description("An Unloading Stop)")]
    [EnumMember(Value = "unloading")]
    Unloading = 2,

    /// <summary>
    /// A Fuel Stop 
    /// </summary>
    [Description("A Fuel Stop")]
    [EnumMember(Value = "fuelStop")]
    FuelStop = 3,

    /// <summary>
    /// A Border Cross
    /// </summary>
    [Description("A Border Cross")]
    [EnumMember(Value = "borderCross")]
    BorderCross = 4,

    /// <summary>
    /// A Way Point
    /// </summary>
    [Description("A Way Point")]
    [EnumMember(Value = "wayPoint")]
    WayPoint = 5,

    /// <summary>
    /// Yard Navigation Stop
    /// </summary>
    [Description("Yard Navigation Stop")]
    [EnumMember(Value = "yardNavigation")]
    YardNavigation = 6,
  }

  /// <summary>
  /// Describes how a barcode was set
  /// </summary>
  [Description("Describes how a barcode was set")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties(false)]
  public enum BarcodeScanType
  {
    /// <summary>
    /// A Unknown SetType
    /// </summary>
    [Description("A Unknown SetType")]
    [EnumMember(Value = "unknown")]
    Unknown = 0,

    /// <summary>
    /// Barcode was scanned
    /// </summary>
    [Description("Barcode was scanned")]
    [EnumMember(Value = "scan")]
    Scan = 1,

    /// <summary>
    /// Manual set
    /// </summary>
    [Description("Manual set")]
    [EnumMember(Value = "manual")]
    Manual = 2,

    /// <summary>
    /// Automatic set by rule
    /// </summary>
    [Description("Automatic set by rule")]
    [EnumMember(Value = "rule")]
    Rule = 3,

    /// <summary>
    /// Automatic set by Geofence
    /// </summary>
    [Description("Automatic set by Geofence")]
    [EnumMember(Value = "geofence")]
    Geofence = 4,

    /// <summary>
    /// Barcode was added an not included in the initial dataset
    /// </summary>
    [Description("Barcode was added an not included in the initial dataset")]
    [EnumMember(Value = "additional")]
    Additional = 5,

    /// <summary>
    /// Barcode was entered via the keyboard
    /// </summary>
    [Description("Barcode was entered via the keyboard")]
    [EnumMember(Value = "scanInput")]
    Scan_Input = 6,
  }

  /// <summary>
  /// Types of the load (pickup, drop off)
  /// </summary>
  [Description("Types of the load (pickup, drop off)")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties(false)]
  public enum LoadType
  {
    /// <summary>
    /// Unknown load
    /// </summary>
    [Description("Unknown load")]
    [EnumMember(Value = "unknown")]
    Unknown = -1,

    /// <summary>
    /// A Pickup
    /// </summary>
    [Description("A pickup")]
    [EnumMember(Value = "pickup")]
    Pickup = 1,

    /// <summary>
    /// A delivery
    /// </summary>
    [Description("A delivery")]
    [EnumMember(Value = "delivery")]
    Delivery = 2
  }

  /// <summary>
  /// Defines the type of a document
  /// </summary>
  [Description(
      "Defines the type of a document")]
  [ConiziAdditionalProperties(false)]
  public enum EdiDocumentType
  {
    /// <summary>
    /// An unknown document
    /// </summary>
    [EnumMember(Value = "unknown")] Unknown = -1,

    /// <summary>
    /// A Proof of Delivery (POD)
    /// </summary>
    [EnumMember(Value = "proof_of_delivery")]
    ProofOfDelivery = 1,

    /// <summary>
    /// A Waybill
    /// </summary>
    [EnumMember(Value = "waybill")] Waybill = 2,

    /// <summary>
    /// Delivery Note
    /// </summary>
    [EnumMember(Value = "delivery_note")] DeliveryNote = 3,

    /// <summary>
    /// Packaging List
    /// </summary>
    [EnumMember(Value = "packaging_list")] PackagingList = 4,

    /// <summary>
    /// Other Document
    /// </summary>
    [EnumMember(Value = "other_document")] OtherDocument = 99,
  }

  /// <summary>
  /// Defines the type of a document
  /// </summary>
  [Description(
      "Defines the type of a document")]
  [ConiziAdditionalProperties(false)]
  public enum EdiImageType
  {
    /// <summary>
    /// An unknown image type
    /// </summary>
    [EnumMember(Value = "unknown")] Unknown = -1,

    /// <summary>
    /// An image of damaged goods
    /// </summary>
    [EnumMember(Value = "damage")] Damage = 1,

    /// <summary>
    /// An image of load securing
    /// </summary>
    [EnumMember(Value = "load_securing")] LoadSecuring = 2,

    /// <summary>
    /// An image of an accident
    /// </summary>
    [EnumMember(Value = "accident")] Accident = 3,

    /// <summary>
    /// Other image
    /// </summary>
    [EnumMember(Value = "other_image")] OtherDocument = 99,
  }

  /// <summary>
  /// Defines the state of the Vehicle Engine and Ignition
  /// </summary>
  [Description(
      "Defines the state of a vehicle")]
  [ConiziAdditionalProperties(false)]
  public enum EdiVehicleEngineState
  {
    /// <summary>
    /// Vehicle Ignition and Engine is off
    /// </summary>
    [EnumMember(Value = "off")] Off = -1,

    /// <summary>
    /// Vehicle Ignition is on, but Engine is off
    /// </summary>
    [EnumMember(Value = "ignition")] Ignition = 1,

    /// <summary>
    /// Vehicle Engine is on
    /// </summary>
    [EnumMember(Value = "on")] On = 2,
  }

}