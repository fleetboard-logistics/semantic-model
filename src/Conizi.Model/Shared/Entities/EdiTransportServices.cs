using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Transport Services
    /// </summary>
    [DisplayName("Transport Services")]
    [Description("")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTransportServices : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Neutral addresses which are shown to the shipper or consignee in order to conceal the actual shipper or recipient of the goods
        /// </summary>
        public EdiAnonymity Anonymity { get; set; }

        /// <summary>
        /// General notifications about the transport
        /// </summary>
        public EdiTransportNotification Notification { get; set; }

        /// <summary>
        /// Special loading equipment, like a fork lift, crane...
        /// </summary>
        public EdiSpecialEquipment SpecialEquipment { get; set; }
    }
}