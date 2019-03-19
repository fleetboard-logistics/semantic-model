using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Schema;

namespace Conizi.Model.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class SchemaResult
    {
        [Required]
        public string Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string File { get; set; }

        public string Model { get; set; }

        [Required]
        public string Version { get; set; }

        [Required]
        public JSchema JSchema { get; set; }

        public override string ToString()
        {
            return this.JSchema.ToString(SchemaVersion.Draft6);
        }
    }
}
