using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    public class PickupOrderBulk : EdiModel
    {
        public EdiModel[] Pickuporders { get; set; }
    }
}