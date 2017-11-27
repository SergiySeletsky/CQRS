using Product.Domain.Core.Messages;

namespace Product.Domain.Core.Events
{
    public interface IEventHandler<in T> : IMessageHandler<T> where T : IEvent
    {
    }
}
