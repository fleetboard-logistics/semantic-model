using System;
using System.ComponentModel;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
   
    /// <summary>
    /// Requirements for the delivery or pickup time
    /// </summary>
    
    [DisplayName("Time options")]
    [Description("Requirements for the delivery or pickup time")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTimeOptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The consignment must be delivered until the given date
        /// </summary>
        public EdiNotAfter NotAfter { get; set; }

        /// <summary>
        /// The consignment must not be delivered before the given date
        /// </summary>
        public EdiNotBefore NotBefore { get; set; }

        /// <summary>
        /// The consignment must be delivered at the given date (and in the given time window)
        /// </summary>
        public EdiFixedDay FixedDay { get; set; }

        /// <summary>
        /// The consignment must be delivered within the given week of the year
        /// </summary>
        public EdiFixedWeek FixedWeek { get; set; }

        /// <summary>
        /// The consignment should be delivered on a saturday
        /// </summary>
        public EdiWeekendSaturday WeekendSaturday { get; set; }

        /// <summary>
        /// The consignment must be delivered on the next working day"
        /// </summary>
        public EdiNextDay NextDay { get; set; }

        /// <summary>
        /// The consignment must be delivered on the same day
        /// </summary>
        public EdiSameDay SameDay { get; set; }

        /// <summary>
        /// The consignment must be delivered in the evening hours
        /// </summary>
        public EdiEvening Evening { get; set; }

        /// <summary>
        /// The goods must be picked up on the same day
        /// </summary>
        public EdiSameDayPickup SameDayPickup { get; set; }
    }

    /// <summary>
    /// The consignment must be delivered until the given date
    /// </summary>
    
    [DisplayName("Not after")]
    [Description("The consignment must be delivered until the given date")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotAfter : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Not after Date (Day)
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime Date { get; set; }
    }

    /// <summary>
    /// The consignment must not be delivered before the given date
    /// </summary>
    
    [DisplayName("Not Before")]
    [Description("The consignment must not be delivered before the given date")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotBefore : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Not before Date (Day: yyyy-MM-dd => 2019-02-14)
        /// </summary>
        [JsonConverter(typeof(ConiziDateConverter))]
        [ConiziDateOnly]
        public DateTime Date { get; set; }
    }

    /// <summary>
    /// The consignment must be delivered at the given date (and in the given time window)
    /// </summary>
    
    [DisplayName("Fixed day")]
    [Description("The consignment must be delivered at the given date (and in the given time window)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiFixedDay : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Date (Day)
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime Date { get; set; }
       
        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time From (HH:mm:ss)")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        /// <summary>
        /// Until time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time Until (HH:mm:ss)")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }
    /// <summary>
    /// The consignment must be delivered within the given week of the year
    /// </summary>
    
    [DisplayName("Fixed week")]
    [Description("The consignment must be delivered within the given week of the year")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiFixedWeek : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Year for  delivery / pickup
        /// </summary>
        [DisplayName("Year for  delivery / pickup")]
        public string Year { get; set; }

        /// <summary>
        /// Week of the year for delivery / pickup
        /// </summary>
        [DisplayName("Week of the year for delivery / pickup")]
        public string WeekOfYear { get; set; }
    }

    /// <summary>
    /// The consignment should be delivered on a saturday
    /// </summary>
    
    [DisplayName("Saturday")]
    [Description("The consignment should be delivered on a saturday")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiWeekendSaturday : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Date (Day)
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        /// <summary>
        /// Until time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }

    /// <summary>
    /// The consignment must be delivered on the next working day
    /// </summary>
    
    [DisplayName("Next day")]
    [Description("The consignment must be delivered on the next working day")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNextDay : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Date (Day)
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        /// <summary>
        /// Until time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }
    
    /// <summary>
    /// 
    /// </summary>
    
    [DisplayName("Same day")]
    [Description("The consignment must be delivered on the same day")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSameDay : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Date (Day)
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        /// <summary>
        /// Until time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }

    /// <summary>
    /// The consignment must be delivered in the evening hours
    /// </summary>
    
    [DisplayName("Evening")]
    [Description("The consignment must be delivered in the evening hours")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEvening : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Date (Day)
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        /// <summary>
        /// Until time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }

    /// <summary>
    /// The goods must be picked up on the same day
    /// </summary>
    
    [DisplayName("Same day pickup")]
    [Description("The goods must be picked up on the same day")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSameDayPickup : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Date (Day)
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }

    /// <summary>
    /// The date on which the pickup order should be processed by the contracted partner
    /// </summary>
    [DisplayName("Pickup date")]
    [Description("The date on which the pickup order should be processed by the contracted partner")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    
    public class EdiPickupDate
    {
        /// <summary>
        /// Date (Day)
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        /// <summary>
        /// From time (HH:mm:ss)
        /// </summary>
        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }
}