


namespace MediatorClinicApp.Mediators
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague sender);
    }
}
