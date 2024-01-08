namespace RelationsNaN.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public List<GamePurchase> GamePurchases { get; set; }
    }
}
