using Product.Domain.Core.Commands;
using Product.Domain.Core.Messages;
using Product.Domain.WriteModel.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Domain.WriteModel.Handlers
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        public async Task<ICommandResult> Handle(CreateUserCommand message)
        {
            return await Task.FromResult(CommandResult.Success);
        }
    }
}
