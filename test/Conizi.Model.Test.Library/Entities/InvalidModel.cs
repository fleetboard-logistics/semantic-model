using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Test.Library.Entities
{
    [ConiziSchema("models/v1/invalidModel.net", "invalidModel.json")]
    public class InvalidModel : EdiDocument
    {

    }
}
