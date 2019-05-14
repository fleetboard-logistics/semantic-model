using System.ComponentModel;
using System.Runtime.Serialization;
using Conizi.Model.Shared.Attributes;

namespace Conizi.Model.Shared.Definitions
{
    /// <summary>
    /// Determines how the current message should be handled, e.g. whether the stops / consignments should be added removed, ..."
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
}