using MediatorClinicApp.MainCharacters;
using System;

namespace MediatorClinicApp.Mediators
{
    public class ClinicMediator : Mediator
    {
        public Client Client { get; set; }
        public Therapist Therapist { get; set; }
        public Surgeon Surgeon { get; set; }
        public Dentist Dentist { get; set; }

        public override void Send(string message, Colleague sender)
        {
            if (sender == Client)
            {
                if (message.ToLower().Contains("tooth") || message.ToLower().Contains("dent") || message.ToLower().Contains("dentist"))
                {
                    MessageReceived?.Invoke(Dentist.Receive(message));
                }
                else if (message.ToLower().Contains("surgery") || message.ToLower().Contains("cut") || message.ToLower().Contains("surgeon"))
                {
                    MessageReceived?.Invoke(Surgeon.Receive(message));
                }
                else
                {
                    MessageReceived?.Invoke(Therapist.Receive(message));
                }
            }
        }

        public event Action<string> MessageReceived;
    }

}
