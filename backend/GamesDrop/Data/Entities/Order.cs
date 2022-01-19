using System;
using System.Collections.Generic;

namespace GamesDrop.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
        public Payment Payment { get; set; }
        public IEnumerable<OrderGame> OrderGames { get; set; }
    }
}