namespace RelationsNaN.Models
{
    public class GamePurchaseV2
    {
        public int Id { get; set; }

        public int GameId { get; set; }
        public int PurchaseId { get; set; }

        public int Count { get; set; }
    }
}
