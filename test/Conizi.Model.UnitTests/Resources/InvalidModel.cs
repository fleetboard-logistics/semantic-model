using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.UnitTests.Resources
{
    [ConiziSchema("models/v1/invalidModel.net", "invalidModel.json")]
    public class InvalidModel : EdiDocument
    {

    }
}
