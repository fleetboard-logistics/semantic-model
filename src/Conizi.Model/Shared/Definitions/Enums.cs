using System.ComponentModel;
using System.Runtime.Serialization;
using Conizi.Model.Shared.Attributes;

namespace Conizi.Model.Shared.Definitions
{
    public enum LoadType
    {
        Unknown = 0,
        Pickup = 1,
        DropOff = 2
    }

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

    [Description("Determines the unit of a given property")]
    [ConiziAdditionalProperties(false)]
    public enum MeasurementUnitCode
    {
        [Description("Distance Values are measured in kilometres")]
        [EnumMember(Value = "KMT")]
        Kilometer,
        [Description("Distance Values are measured in nautical miles")]
        [EnumMember(Value = "NMI")]
        NauticalMile,
        [Description("Distance Values are measured in (Statute/English) Mile")]
        [EnumMember(Value = "SMI")]
        StatuteMile
    }

    [Description("Determines a priority of a given message")]
    [ConiziAdditionalProperties(false)]
    public enum UrgencyCode
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "low")]
        Low,
    }
}