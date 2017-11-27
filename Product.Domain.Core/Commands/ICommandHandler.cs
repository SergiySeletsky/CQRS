using Product.Domain.Core.Messages;

namespace Product.Domain.Core.Commands
{
    public interface ICommandHandler<in T> : IMessageHandler<T> where T : ICommand
    {
    }
}
