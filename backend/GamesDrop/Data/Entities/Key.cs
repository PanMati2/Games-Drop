namespace GamesDrop.Data.Entities
{
    public class Key
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string GameKey { get; set; }

        public OrderGame OrderGame { get; set; }
        public Game Game { get; set; }
    }
}