using System.ComponentModel.DataAnnotations;
using Conizi.Model.Core.Tools;
using Newtonsoft.Json.Schema;

namespace Conizi.Model.Core.Entities
{
    /// <summary>
    /// The result object of a model generation by the <see cref="Generator"/>
    /// </summary>
    public class GenerationResult
    {
        /// <summary>
        /// The schema Id
        /// </summary>
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// The schema title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The schema description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The file the schema was stored
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// The model used to generate the schema
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The version was used to generate the schema
        /// </summary>
        [Required]
        public string Version { get; set; }

        /// <summary>
        /// The schema as JSchema
        /// </summary>
        [Required]
        public JSchema JSchema { get; set; }

        /// <summary>
        /// The content of the generated schema as string. Generated in JSON Schema Draft 6 as default.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.JSchema.ToString(SchemaVersion.Draft6);
        }
    }
}
