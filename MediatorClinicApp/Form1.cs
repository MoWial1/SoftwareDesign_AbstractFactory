using MediatorClinicApp.MainCharacters;
using MediatorClinicApp.Mediators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediatorClinicApp
{
    public partial class Form1 : Form
    {
        private ClinicMediator mediator;
        private Client client;

        public Form1()
        {
            InitializeComponent();
            InitializeMediator();
        }

        // Створення суб‑об‑єктів та підключення медіатора
        private void InitializeMediator()
        {
            mediator = new ClinicMediator();

            client = new Client(mediator);
            var therapist = new Therapist(mediator);
            var surgeon = new Surgeon(mediator);
            var dentist = new Dentist(mediator);

            mediator.Client = client;
            mediator.Therapist = therapist;
            mediator.Surgeon = surgeon;
            mediator.Dentist = dentist;

            mediator.MessageReceived += DisplayResponse;
        }

        // Відобразити відповідь у ListBox
        private void DisplayResponse(string response)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() => lstOutput.Items.Add(response)));
            }
            else
            {
                lstOutput.Items.Add(response);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtInput.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                client.Send(message);
                txtInput.Clear();
            }
        }
    }

}
