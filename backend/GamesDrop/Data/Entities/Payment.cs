using GamesDrop.Data.Enums;

namespace GamesDrop.Data.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public int PaymentMethodId { get; set; }

        public Order Order { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}