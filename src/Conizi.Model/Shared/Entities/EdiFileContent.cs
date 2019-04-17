using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Transfers file data like a picture, pdf, txt...
    /// </summary>
    [DisplayName("File Content")]
    [Description("Transfers file data like a picture, pdf, txt..")]
    [JsonObject("fileContent")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties()]
    public class EdiFileContent : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The file name
        /// </summary>
        [DisplayName("File Name")]
        [Description("The file name")]
        public string FileName { get; set; }

        /// <summary>
        /// The content type like application/pdf, image/png...
        /// </summary>
        [DisplayName("Content Type")]
        [Description("The content type like application/pdf, image/png...")]
        public string ContentType { get; set; }

        /// <summary>
        /// The content/data of a file/object
        /// </summary>
        public EdiBinaryData BinaryData { get; set; }

        /// <summary>
        /// Reference to a file in an online storage
        /// </summary>
        public EdiFileReference FileReference { get; set; }
    }

    /// <summary>
    /// The content/data of a file/object
    /// </summary>
    [DisplayName("Binary Data")]
    [Description("The content/data of a file")]
    [JsonObject("binaryData")]
    public class EdiBinaryData
    {
        /// <summary>
        /// The length (bytes) of submitted data
        /// </summary>
        [DisplayName("Data length")]
        [Description("The length (bytes) of submitted data")]
        public int Length { get; set; }

        /// <summary>
        /// The submitted data as byte array, be aware large files > 100KByte should be submitted as <see cref="EdiFileReference"/>
        /// </summary>
        [DisplayName("Data bytes")]
        [Description("The submitted data as base64 string, be aware large files > 100KByte should be submitted as fileReference")]
        [Required] public byte[] Data { get; set; }
    }


    /// <summary>
    /// Reference to a file in an online storage
    /// </summary>
    [DisplayName("File Reference")]
    [Description("Reference to a file in an online storage")]
    [JsonObject("fileReference")]
    public class EdiFileReference
    {
        /// <summary>
        /// Unique Id for a file
        /// </summary>
        [DisplayName("File Id")]
        [Description("Unique Id for a file")]
        public string FileId { get; set; }

        /// <summary>
        /// The length (bytes) of submitted data
        /// </summary>
        [DisplayName("Data length")]
        [Description("The length (bytes) of submitted data")]
        public int Length { get; set; }

        /// <summary>
        /// An absolute URL to a file on the online storage
        /// </summary>
        [DisplayName("Absolute Uri")]
        [Description("An absolute URL to a file on the online storage")]
        [Url] [Required] public string AbsoluteUri { get; set; }

        /// <summary>
        /// The URL is valid from date
        /// </summary>
        [DisplayName("Uri Valid From")]
        [Description("The URL is valid from date")]
        public DateTime UriValidFrom { get; set; }

        /// <summary>
        /// The URL is valid until date
        /// </summary>
        [DisplayName("Uri Valid To")]
        [Description("The URL is valid until date")]
        public DateTime UriValidTo { get; set; }
    }
}