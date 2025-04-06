using MediatorClinicApp.Mediators;


namespace MediatorClinicApp.MainCharacters
{
    public class Dentist : Colleague
    {
        public Dentist(Mediator mediator) : base(mediator) { }

        public override string Receive(string message)
        {
            return $"Dentist received the request: {message}";
        }
    }
}
