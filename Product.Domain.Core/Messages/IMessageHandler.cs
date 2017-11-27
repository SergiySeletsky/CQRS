using System.Threading;
using System.Threading.Tasks;

namespace Product.Domain.Core.Messages
{
    /// <summary>
    /// Interface for generic message handlers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMessageHandler<in T> where T : IMessage
    {
        /// <summary>
        /// Handle message
        /// </summary>
        /// <param name="message">abstract message</param>
        /// <returns>async task awaiter</returns>
        Task Handle(T message, CancellationToken token = default(CancellationToken));
    }
}
