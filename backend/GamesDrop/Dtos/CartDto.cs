using System.Collections.Generic;

namespace GamesDrop.Dtos
{
    public class CartDto
    {
        public IEnumerable<CartItemDto> CartItems { get; set; }
    }
}