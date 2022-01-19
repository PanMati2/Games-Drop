using System.Collections.Generic;

namespace GamesDrop.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public User User { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
    }
}