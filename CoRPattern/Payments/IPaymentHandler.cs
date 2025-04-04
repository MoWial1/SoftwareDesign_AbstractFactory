

namespace CoRPattern.Payments
{
    public interface IPaymentHandler
    {
        IPaymentHandler SetNext(IPaymentHandler handler);
        void Handle(PaymentRequest request);
    }
}
