using System;

namespace GamesDrop.Data.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int PercentDiscount { get; set; }
        public int GameId { get; set; }

        public Game Game { get; set; }
    }
}