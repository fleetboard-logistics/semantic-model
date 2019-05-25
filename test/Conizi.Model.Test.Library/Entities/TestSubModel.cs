using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Core.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Test.Library.Entities
{
    [ConiziSchema("https://model.conizi.io/v1/test/test-sub.json", "test-sub.json")]
    [DisplayName("Test Sub Model")]
    [Description("This is the conizi test sub model")]
    [ConiziAllowXProperties]
    public class TestSubModel : EdiModel
    {
        /// <summary>
        /// My prop
        /// </summary>
        [Required]
        public string MyProp { get; set; }
    }
}
