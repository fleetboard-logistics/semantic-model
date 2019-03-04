using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    public class Manifest : EdiDocument
    {
        public EdiLine[] EdiLines { get; set; }
    }

    public class EdiLine
    {
        public int LineNo { get; set; }
        public EdiDocument Consignment { get; set; }
    }
}