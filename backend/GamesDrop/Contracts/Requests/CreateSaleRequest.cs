using System;
using System.ComponentModel.DataAnnotations;

namespace GamesDrop.Contracts.Requests
{
    public class CreateSaleRequest
    {
        [Required] public int GameId { get; set; }

        [Required] public DateTime ValidFrom { get; set; }

        [Required] public DateTime ValidTo { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Zniżka musi być w przedziale 1-100")]
        public int PercentDiscount { get; set; }
    }
}