using System;


namespace CoRPattern.Payments
{
    public class CreditCardHandler : IPaymentHandler
    {
        private IPaymentHandler nextHandler;

        public IPaymentHandler SetNext(IPaymentHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public void Handle(PaymentRequest request)
        {
            if (request.PaymentMethod.Equals("CreditCard", StringComparison.OrdinalIgnoreCase))
            {
                request.Result = $"Оплата {request.Amount} грн за допомогою кредитної картки успішна.";
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(request);
            }
            else
            {
                request.Result = "Спосіб оплати не підтримується.";
            }
        }
    }
}
