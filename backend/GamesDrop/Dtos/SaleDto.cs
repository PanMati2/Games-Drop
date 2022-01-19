using System;

namespace GamesDrop.Dtos
{
    public class SaleDto
    {
        public int Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int PercentDiscount { get; set; }
        public int GameId { get; set; }
    }
}