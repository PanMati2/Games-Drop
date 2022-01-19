namespace GamesDrop.Data.Entities
{
    public class OrderGame
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int OrderId { get; set; }
        public int KeyId { get; set; }
        public decimal Price { get; set; }
        public int PercentDiscount { get; set; }

        public Game Game { get; set; }
        public Order Order { get; set; }
        public Key Key { get; set; }
    }
}