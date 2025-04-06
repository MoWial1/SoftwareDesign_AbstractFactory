using MediatorClinicApp.Mediators;


namespace MediatorClinicApp.MainCharacters
{
    public class Surgeon : Colleague
    {
        public Surgeon(Mediator mediator) : base(mediator) { }

        public override string Receive(string message)
        {
            return $"Surgeon received the request: {message}";
        }
    }
}
