using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities.Tour
{
    /// <summary>
    ///Events indicating successful completion of a task, consignment has been forwarded
    /// </summary>
    [DisplayName("Work completed - forwarded")]
    [Description("Events indicating successful completion of a task, consignment has been forwarded")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventCompletion: EdiEventBase
    {
        /// <summary>
        /// Completed by another party
        /// </summary>
        //[DisplayName("Completed by")]
        //[Description("Completed by another party")]
        public EdiEmptyExtendableObject CompletedBy { get; set; }

        /// <summary>
        /// Consignment was forwarded
        /// </summary>
        //[DisplayName("Forwarded")]
        //[Description("Consignment was forwarded")]
        public EdiEmptyExtendableObject Forwarded { get; set; }

        /// <summary>
        /// Name of the person which rejected the consignment
        /// </summary>
        [DisplayName("Signee")]
        [Description("Name of the person which rejected the consignment")]
        public string Signee { get; set; }

        /// <summary>
        /// Time spent waiting during delivery
        /// </summary>
        [DisplayName("Wait time")]
        [Description("Time spent waiting during delivery")]
        public string WaitTime { get; set; }
    }
}