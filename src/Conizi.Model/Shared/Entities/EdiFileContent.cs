using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("content")]
    public class EdiFileContent
    {
        public EdiFileData FileData { get; set; }

        public EdiFileReference FileReference { get; set; }
    }

    [JsonObject("oneOf", IsReference =  false, ItemIsReference =  false)]
    public class ConiziOneOf<T1, T2>
    {

    }

    [KnownType(typeof(EdiFileData))]
    [KnownType(typeof(EdiFileReference))]
    public abstract class EdiFileBase
    {
        public string FileName { get; set; }
    }

    [JsonObject("fileData", IsReference = false)]
    public class EdiFileData : EdiFileBase
    {  
        public string ContentType { get; set; }

        [Required] public byte[] Data { get; set; }
    }

    [JsonObject("fileReference", IsReference = false)]
    public class EdiFileReference : EdiFileBase
    {
        public string ContentType { get; set; }

        [Url] [Required] public string AbsoluteUri { get; set; }

        public DateTime UriValidFrom { get; set; }

        public DateTime UriValidTo { get; set; }
    }
}