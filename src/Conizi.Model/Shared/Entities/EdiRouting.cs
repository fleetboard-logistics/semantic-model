using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about the route take by this consignment/pickup order
    /// </summary>
    [DisplayName("Routing")]
    [Description("Information about the route take by this consignment/pickup order")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    
    public class EdiRouting 
    {
        /// <summary>
        /// The address of the party which is sending the goods. This is usually the place where the pickup originated
        /// </summary>
        public EdiAddress Shipper { get; set; }

        /// <summary>
        /// The address of the good's recipient
        /// </summary>
        public EdiAddress Consignee { get; set; }

        /// <summary>
        /// The address of the party which is sending the goods. This is usually the place where the transport originated
        /// </summary>
        public EdiAddress LoadingAddress { get; set; }

        /// <summary>
        /// The drop of point for the consignment, e.g. the exact address of the warehouse if the consignee has multiple warehouses
        /// </summary>
        public EdiAddress UnloadingAddress { get; set; }
    }
}