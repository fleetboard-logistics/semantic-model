using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Conizi.Model.Shared.Helper
{
    /// <summary>
    /// Key field for full text search
    /// </summary>
    public class KeyField
    {
        /// <summary>
        /// The key search for
        /// </summary>
        private string Key { get; set; }

        /// <summary>
        /// The value as object
        /// </summary>
        private object Value { get; set; }
    }
}
