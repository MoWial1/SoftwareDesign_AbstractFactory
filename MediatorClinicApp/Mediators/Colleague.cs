

namespace MediatorClinicApp.Mediators
{
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public abstract string Receive(string message);
    }
}
