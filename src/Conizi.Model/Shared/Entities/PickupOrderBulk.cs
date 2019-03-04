namespace Conizi.Model.Shared.Entities
{
    public class PickupOrderBulk : EdiDocument
    {
        public EdiDocument[] Pickuporders { get; set; }
    }
}