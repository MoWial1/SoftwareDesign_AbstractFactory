using CoRPattern.Payments;
using System;
using System.Windows.Forms;

namespace CoRPattern
{
    public partial class Form1 : Form
    {
        private IPaymentHandler paymentChain;

        public Form1()
        {
            InitializeComponent();
            InitializePaymentChain();
            InitializeUI();
        }

        private void InitializePaymentChain()
        {
            // Створюємо обробники та будуємо ланцюжок: CreditCard -> PayPal -> Crypto
            IPaymentHandler creditCardHandler = new CreditCardHandler();
            IPaymentHandler payPalHandler = new PayPalHandler();
            IPaymentHandler cryptoHandler = new CryptoHandler();

            creditCardHandler.SetNext(payPalHandler).SetNext(cryptoHandler);
            paymentChain = creditCardHandler;
        }

        private void InitializeUI()
        {
            // Заповнюємо ComboBox способами оплати
            //cmbPaymentMethod.Items.Add("CreditCard");
            //cmbPaymentMethod.Items.Add("PayPal");
            //cmbPaymentMethod.Items.Add("Криптовалюта");
            cmbPaymentMethod.SelectedIndex = 0;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentRequest request = new PaymentRequest();
            request.PaymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Введіть коректну суму оплати!");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Сума оплати не може бути 0 або від'ємною!");
                return;
            }


            request.Amount = amount;

            paymentChain.Handle(request);
            lblResult.Text = request.Result;
        }
    }
}
