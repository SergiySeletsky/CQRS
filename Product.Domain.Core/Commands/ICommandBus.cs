using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Domain.Core.Commands
{
    public interface ICommandBus
    {
        Task Send<T>(T command, CancellationToken token = default(CancellationToken)) where T : ICommand;
    }
}
