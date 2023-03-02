namespace PrincipiosSOLID.DIP
{
    public class RabbitMqService : IMessageBusService
    {
        public void Publish(string queue, object data)
        {
            // Publicar a mensagem na fila
        }
    }
}
