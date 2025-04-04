
namespace CoRPattern.Payments
{
    public class PaymentRequest
    {
        public string PaymentMethod { get; set; }  // "Кредитна картка", "PayPal", "Криптовалюта"
        public decimal Amount { get; set; }
        public string Result { get; set; }         // Результат оплати
    } 
}
