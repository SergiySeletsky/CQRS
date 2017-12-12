using Product.Domain.Core.Commands;
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
        public Task Handle(CreateUserCommand message, CancellationToken token = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
