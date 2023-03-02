namespace PrincipiosSOLID.OCP
{
    public enum PaymentType
    {
        Credit,
        Debit,
        LoyaltyPoints
    }

    public class OrderPaymentInfo
    {
        public Guid OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentType Type { get; set; }
    }
}
