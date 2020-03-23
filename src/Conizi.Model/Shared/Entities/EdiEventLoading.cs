using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// Events that occur during the loading process
    /// </summary>
    [DisplayName("Loading")]
    [Description("Events that occur during the loading process")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventLoading : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occurred while loading the order
        /// </summary>
        public EdiEventLoadingExceptions Exceptions { get; set; }

    }


    /// <summary>
    /// Detailed information about the exceptions that occurred while loading the order
    /// </summary>
    [DisplayName("Loading Exception")]
    [Description("Detailed information about the exceptions that occurred while loading the order")]
    public class EdiEventLoadingExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The cargo is damaged
        /// </summary>
        [DisplayName("Damaged")]
        [Description("The cargo is damaged")]
        public bool? Damaged { get; set; }

        /// <summary>
        /// The cargo is delayed
        /// </summary>
        [DisplayName("Late Arrival")]
        [Description("The cargo is delayed")]
        public bool? LateArrival { get; set; }

        /// <summary>
        /// The load is missing
        /// </summary>
        [DisplayName("Missing")]
        [Description("The load is missing")]
        public bool? Missing { get; set; }

        /// <summary>
        /// The status is not verifiable
        /// </summary>
        [DisplayName("Verifiable")]
        [Description("The status is not verifiable")]
        public bool? NotVerifiable { get; set; }

        /// <summary>
        /// There are differences in the packaging
        /// </summary>
        [DisplayName("Packaging Differences")]
        [Description("There are differences in the packaging")]
        public bool? PackagingDifferences { get; set; }

        /// <summary>
        /// The load is partly missing
        /// </summary>
        [DisplayName("Partly Missing")]
        [Description("The load is partly missing")]
        public bool? PartlyMissing { get; set; }


        /// <summary>
        /// The load has differences in quantity
        /// </summary>
        [DisplayName("Quantity Differences")]
        [Description("The load has differences in quantity")]
        public bool? QuantityDifferences { get; set; }
    }
}
