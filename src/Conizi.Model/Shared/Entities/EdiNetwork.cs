using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// The network under which rules the consignment should be processed
    /// </summary>
    [DisplayName("Network")]
    [Description("The network under which rules the consignment should be processed")]
    [ConiziAdditionalProperties(false)]
    public class EdiNetwork
    {
        /// <summary>
        /// The name of the network. This is often identical to the name of the code list. Since the same code list may however be used outside the network, this field independently allows to specify the network
        /// </summary>
        [DisplayName("Name of the network")]
        [Description("The name of the network. This is often identical to the name of the code list. Since the same code list may however be used outside the network, this field independently allows to specify the network")]
        public string NetworkId { get; set; }

        /// <summary>
        /// The name of the code list which specifies how the receiving system should interpret the codes used
        /// </summary>
        [DisplayName("Name of the code list used")]
        [Description("The name of the code list which specifies how the receiving system should interpret the codes used")]
        public string Codelist { get; set; }

        /// <summary>
        /// The product allows to distinguish different processes within one network, effectively sub classing the network
        /// </summary>
        [DisplayName("Name of the product")]
        [Description("The product allows to distinguish different processes within one network, effectively sub classing the network")]
        public string Product { get; set; }
    }
}