namespace PrincipiosSOLID.OCP
{
    public class CreditCardMethod : IOrderPaymentMethod
    {
        public CreditCardMethod(OrderPaymentInfo paymentInfo)
        {

        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
