namespace Example.Infrastructure.Messaging
{
    public interface IEventSender
    {
        Task SendAsync<T>(T eventMessage) where T : class;
    }
}