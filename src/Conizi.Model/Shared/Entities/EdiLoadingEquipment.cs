﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Additional loading aids which are not part of the consignment but which have been added to safely transport the goods
    /// </summary>
    
    [DisplayName("Additional loading equipment")]
    [Description("Additional loading aids which are not part of the consignment but which have been added to safely transport the goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAdditionalLoadingEquipment : EdiPatternPropertiesBase
    {
        /// <summary>
        /// EUR pallets as defined by European Pallet Association (EPAL)
        /// </summary>
        [DisplayName("EPAL")]
        [Description("EUR pallets as defined by European Pallet Association (EPAL)")]
        public int? EurPallets { get; set; }

        /// <summary>
        /// EUR Box pallets as defined by European Pallet Association (EPAL)
        /// </summary>
        [DisplayName("EUR box pallets")]
        [Description("EUR Box pallets as defined by European Pallet Association (EPAL)")]
        public int? EurBoxes { get; set; }

    }

    /// <summary>
    /// Information about loading equipment exchange
    /// </summary>
    
    [DisplayName("Loading equipment exchange")]
    [Description("Information about loading equipment exchange")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLoadingEquipmentExchange : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Loading Equipment was exchanged
        /// </summary>
        [DisplayName("Exchanged")]
        [Description("Loading Equipment was exchanged")]
        [JsonRequired]
        public bool? Exchanged { get; set; }

        /// <summary>
        /// Information about the type of loading equipment and the amount
        /// </summary>
        public List<EdiLoadingEquipment> LoadingEquipment { get; set; }

    }

    /// <summary>
    /// Loading equipment
    /// </summary>
    [DisplayName("Loading equipment")]
    [Description("Loading equipment used for transportation")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLoadingEquipment : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Type of loading equipment like eur pallets, euro boxes...
        /// </summary>
        [DisplayName("Loading Equipment Type")]
        [Description("Type of loading equipment like eur pallets, euro boxes...")]
        [JsonConverter(typeof(StringEnumConverter))]
        [Required]
        public LoadingEquipmentType EquipmentType { get; set; }

        /// <summary>
        /// Custom Loading Equipment Name, like specialCoolingBox...
        /// </summary>
        /// <remarks>Should only be used, if the EquipmentType is set to CustomLoadingEquipment!</remarks>
        [DisplayName("Custom Loading Equipment Name")]
        [Description("Custom Loading Equipment Name, like specialCoolingBox...")]
        public string CustomLoadingEquipmentName { get; set; }

        /// <summary>
        /// Add/Load amount of loading equipment
        /// </summary>
        [DisplayName("Amount Loaded")]
        [Description("Add/Load amount of equipment")]
        public int? AmountLoaded { get; set; }

        /// <summary>
        /// Remove/Unload amount of loading equipment
        /// </summary>
        [DisplayName("Amount Unloaded")]
        [Description("Remove/Unload amount of equipment")]
        public int? AmountUnloaded { get; set; }

        /// <summary>
        /// Additional remarks
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }
    }
}