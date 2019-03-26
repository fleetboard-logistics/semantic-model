using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("timeOptions")]
    [DisplayName("Time options")]
    [Description("Requirements for the delivery or pickup time")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTimeOptions : EdiPatternPropertiesBase
    {
        public EdiNotAfter NotAfter { get; set; }

        public EdiNotBefore NotBefore { get; set; }

        public EdiFixedDay FixedDay { get; set; }

        public EdiFixedWeek FixedWeek { get; set; }

        public EdiWeekendSaturday WeekendSaturday { get; set; }

        public EdiNextDay NextDay { get; set; }
        public EdiSameDay SameDay { get; set; }
        public EdiEvening Evening { get; set; }


    }

    [JsonObject("notAfter")]
    [DisplayName("Not after")]
    [Description("The consignment must be deliverd until the given date")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotAfter : EdiPatternPropertiesBase
    {
        [ConiziDateOnly]
        public DateTime Date { get; set; }
    }

    [JsonObject("notBefore")]
    [DisplayName("Not Before")]
    [Description("The consignment must not be deliverd before the given date")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotBefore : EdiPatternPropertiesBase
    {
        [ConiziDateOnly]
        public DateTime Date { get; set; }
    }

    [JsonObject("fixedDay")]
    [DisplayName("Fixed day")]
    [Description("The consignment must be delivered at the given date (and in the given time window)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiFixedDay : EdiPatternPropertiesBase
    {
        [ConiziDateOnly]
        public DateTime Date { get; set; }
       
        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }

    [JsonObject("fixedWeek")]
    [DisplayName("Fixed week")]
    [Description("The consignment must be deliverd within the given week of the year")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiFixedWeek : EdiPatternPropertiesBase
    {
        public string Year { get; set; }
        public string WeekOfYear { get; set; }
    }

    [JsonObject("weekendSaturday")]
    [DisplayName("Saturday")]
    [Description("The consignment should be delivered on a saturday")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiWeekendSaturday : EdiPatternPropertiesBase
    {
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }

    [JsonObject("nextDay")]
    [DisplayName("Next day")]
    [Description("The consignment must be delivered on the next working day")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNextDay : EdiPatternPropertiesBase
    {
   
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }
    
    [JsonObject("sameDay")]
    [DisplayName("Same day")]
    [Description("The consignment must be delivered on the same day")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSameDay : EdiPatternPropertiesBase
    {
   
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }

    [JsonObject("eventing")]
    [DisplayName("Evening")]
    [Description("The consignment must be delivered in the eveneing hours")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEvening : EdiPatternPropertiesBase
    {
   
        [DisplayName("Time From")]
        [ConiziTimeOnly]
        public string TimeFrom { get; set; }

        [DisplayName("Time Until")]
        [ConiziTimeOnly]
        public string TimeUntil { get; set; }
    }
}