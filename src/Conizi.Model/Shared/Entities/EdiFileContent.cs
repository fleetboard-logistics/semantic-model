using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
   
    [JsonObject("fileContent")]
    [KnownType(typeof(EdiFileData))]
    [KnownType(typeof(EdiFileReference))]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties()]
    [ConiziOneOf] 
    public class EdiFileContent : EdiPatternPropertiesBase
    {
        public string FileName { get; set; }

        public string ContentType { get; set; }

        public EdiFileData FileData { get; set; }

        public EdiFileReference FileReference { get; set; }
    }

    [JsonObject("fileData")]
    public class EdiFileData
    {
        [Required] public byte[] Data { get; set; }
    }

    [JsonObject("fileReference")]
    public class EdiFileReference
    {
        [Url] [Required] public string AbsoluteUri { get; set; }

        public DateTime UriValidFrom { get; set; }

        public DateTime UriValidTo { get; set; }
    }
}