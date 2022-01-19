namespace GamesDrop.Data.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int GameId { get; set; }
        public int Quantity { get; set; }

        public Cart Cart { get; set; }
        public Game Game { get; set; }
    }
}