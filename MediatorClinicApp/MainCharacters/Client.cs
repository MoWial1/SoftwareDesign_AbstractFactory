using MediatorClinicApp.Mediators;
using System;


namespace MediatorClinicApp.MainCharacters
{
    public class Client : Colleague
    {
        public Client(Mediator mediator) : base(mediator) { }

        public override string Receive(string message)
        {
            return $"Client received: {message}";
        }
    }
}
