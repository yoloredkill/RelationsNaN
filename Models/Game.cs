namespace RelationsNaN.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Bundle> Bundles { get; set; }
        public List<GamePurchaseV1> GamePurchasesV1 { get; set; }
        public List<GamePurchaseV2> GamePurchasesV2 { get; set; }
    }
}
