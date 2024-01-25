using MixprojectFront.Shared.DTOs.Transactions;

namespace MixprojectFront.Shared.DTOs.PaymentMethods
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Transaction>? Transactions { get; set; }

    }
}
