using System.Collections.Generic;

namespace GamesDrop.Data.Entities
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Payment> Payments { get; set; }
    }
}