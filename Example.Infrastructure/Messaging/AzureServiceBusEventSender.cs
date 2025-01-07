using Azure.Messaging.ServiceBus;
using System.Text.Json;

namespace Example.Infrastructure.Messaging
{
    public class AzureServiceBusEventSender : IEventSender
    {
        private readonly ServiceBusClient client;
        private readonly string topicName;

        public AzureServiceBusEventSender(string connectionString, string topicName)
        {
            client = new ServiceBusClient(connectionString);
            this.topicName = topicName;
        }

        public async Task SendAsync<T>(T eventMessage) where T : class
        {
            var sender = client.CreateSender(topicName);
            var messageBody = JsonSerializer.Serialize(eventMessage);
            var message = new ServiceBusMessage(messageBody);

            try
            {
                await sender.SendMessageAsync(message);
            }
            finally
            {
                await sender.DisposeAsync();
            }
        }
    }
}