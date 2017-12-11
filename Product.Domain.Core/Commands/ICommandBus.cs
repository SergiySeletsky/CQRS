using System.Threading;
using System.Threading.Tasks;

namespace Product.Domain.Core.Commands
{
    public interface ICommandBus
    {
        Task<CommandResult> Send<T>(T command, CancellationToken token = default(CancellationToken)) where T : ICommand;
    }
}
