using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Conizi.Model.Shared.Interfaces
{
    public interface IModel
    {
        /// <summary>
        /// The id (URI) of the model
        /// </summary>
        ///<remarks>
        /// The production ready models are hosted at https://model.conizi.io/[version]
        /// The github repository https://github.com/fleetboard-logistics/semantic-model contains the models source.
        /// Please use the production branch to get a stable version.
        /// </remarks>
        [DisplayName("Json schema")]
        [Description("The used json schema (url/version)")]
        [Required]
        string Schema { get; }

        /// <summary>
        /// Type of the model
        /// </summary>
        Type ModelType { get; set; }
    }
}
