namespace RelationsNaN.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public List<GamePurchaseV2> GamePurchases { get; set; }
    }
}
