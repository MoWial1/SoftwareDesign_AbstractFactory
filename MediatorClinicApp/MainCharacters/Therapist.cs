using MediatorClinicApp.Mediators;


namespace MediatorClinicApp.MainCharacters
{
    public class Therapist : Colleague
    {
        public Therapist(Mediator mediator) : base(mediator) { }

        public override string Receive(string message)
        {
            return $"Therapist received the request: {message}";
        }
    }
}
