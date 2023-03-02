namespace PrincipiosSOLID.DIP
{
    public interface IMessageBusService
    {
        void Publish(string queue, object data);
    }
}