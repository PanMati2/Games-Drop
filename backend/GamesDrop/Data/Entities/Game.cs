using System.Collections.Generic;

namespace GamesDrop.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int PlatformId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool Recommended { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
        public string TrailerUrl { get; set; }

        public IEnumerable<Key> Keys { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
        public IEnumerable<OrderGame> OrderGames { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
        public GameCategory GameCategory { get; set; }
        public GamePlatform GamePlatform { get; set; }
    }
}