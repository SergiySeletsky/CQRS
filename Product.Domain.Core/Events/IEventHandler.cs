using Product.Domain.Core.Messages;
using System.Threading.Tasks;

namespace Product.Domain.Core.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
        /// <summary>
        /// Handle message
        /// </summary>
        /// <param name="message">abstract message</param>
        /// <returns>async task awaiter</returns>
        Task Handle(T message);
    }
}
