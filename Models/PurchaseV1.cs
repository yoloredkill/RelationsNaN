namespace RelationsNaN.Models
{
    public class PurchaseV1
    {
        public int Id { get; set; }
        public List<GamePurchaseV1> GamePurchases { get; set; }
    }
}
