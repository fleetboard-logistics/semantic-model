using System.ComponentModel;
using System.Runtime.Serialization;
using Conizi.Model.Shared.Attributes;

namespace Conizi.Model.Shared.Definitions
{
    /// <summary>
    /// Determines the load type of the current message
    /// </summary>
    public enum LoadType
    {
        Unknown = 0,
        Pickup = 1,
        DropOff = 2
    }

    /// <summary>
    /// Determines how the current message should be handled, e.g. whether the stops / consignments should be added removed, ...
    /// </summary>
    [Description("Determines how the current message should be handled, e.g. whether the stops / consignments should be added removed, ...")]
    [ConiziAdditionalProperties(false)]
    public enum EdiMessageFunctionCode
    {
        [EnumMember(Value = "add")]
        Add = 1,
        [EnumMember(Value = "update")]
        Update = 2,
        [EnumMember(Value = "remove")]
        Remove = 3,
        [EnumMember(Value = "add_partial")]
        AddPartial = 11,
        [EnumMember(Value = "update_partial")]
        UpdatePartial = 12,
        [EnumMember(Value = "remove_partial")]
        RemovePartial = 13
    }

    /// <summary>
    /// Determines the unit in which a given property is measured
    /// </summary>
    [Description("Determines the unit of a given property")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public enum MeasurementUnitCode
    {
        /// <summary>
        /// Values are measured in kilometers
        /// </summary>
        [Description("Distance Values are measured in kilometers")]
        [EnumMember(Value = "KMT")]
        Kilometer,

        /// <summary>
        /// Values are measured in nautical miles
        /// </summary>
        [Description("Distance Values are measured in nautical miles")]
        [EnumMember(Value = "NMI")]
        NauticalMile,

        /// <summary>
        /// Values are measured in miles
        /// </summary>
        [Description("Distance Values are measured in (Statute/English) miles")]
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
}