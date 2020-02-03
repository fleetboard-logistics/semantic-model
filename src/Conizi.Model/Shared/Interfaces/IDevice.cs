using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Conizi.Model.Shared.Interfaces
{
    public interface IDevice
    {
        /// <summary>
        /// The id of the used device
        /// </summary>
        [DisplayName("Device Id")]
        [Description(" The id of the used device")]
        string DeviceId { get; set; }
    }
}
