using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
   
    [JsonObject("FileContent")]
    [KnownType(typeof(EdiFileData))]
    [KnownType(typeof(EdiFileReference))]
    public class EdiFileBase
    {
    }

    [JsonObject("fileData")]
    public class EdiFileData : EdiFileBase
    {

        public string FileName { get; set; }

        public string ContentType { get; set; }

        [Required] public byte[] Data { get; set; }
    }

    [JsonObject("fileReference", IsReference = false)]
    public class EdiFileReference : EdiFileBase
    {
        public string FileName { get; set; }

        public string ContentType { get; set; }

        [Url] [Required] public string AbsoluteUri { get; set; }

        public DateTime UriValidFrom { get; set; }

        public DateTime UriValidTo { get; set; }
    }
}