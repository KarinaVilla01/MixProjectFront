using MixprojectFront.Shared.DTOs.PaymentMethods;

namespace MixprojectFront.Shared.DTOs.Transactions
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Currency { get; set; } = string.Empty;
        public int PaymentMethodId { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid IdClient { get; set; }

        public PaymentMethod? PaymentMethod { get; set; }

    }
}
