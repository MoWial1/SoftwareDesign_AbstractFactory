using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRPattern.Payments
{
    public class CryptoHandler : IPaymentHandler
    {
        private IPaymentHandler nextHandler;

        public IPaymentHandler SetNext(IPaymentHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public void Handle(PaymentRequest request)
        {
            if (request.PaymentMethod.Equals("Cryptocurrency", StringComparison.OrdinalIgnoreCase))
            {
                request.Result = $"Оплата {request.Amount} грн за допомогою криптовалюти успішна.";
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
