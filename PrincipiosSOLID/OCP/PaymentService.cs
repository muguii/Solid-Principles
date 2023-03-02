namespace PrincipiosSOLID.OCP
{
    public class PaymentService
    {
        public void Process(IOrderPaymentMethod orderPaymentMethod)
        {
            orderPaymentMethod.Process();

            //if (paymentInfo.Type == PaymentType.Credit)
            //{
            //    // Integrar com GateWay de Pagamento A
            //} 
            //else if (paymentInfo.Type == PaymentType.Debit)
            //{
            //    // Integrar com GateWay de Pagamento A
            //}
            //else if (paymentInfo.Type == PaymentType.LoyaltyPoints)
            //{
            //    // Chamar serviço interno de Pontos de Fidelidade
            //}
        }
    }
}
