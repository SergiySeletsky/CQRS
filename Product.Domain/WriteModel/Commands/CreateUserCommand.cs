using System;
using Product.Domain.Core.Commands;

namespace Product.Domain.WriteModel.Commands
{
    public class CreateUserCommand : Command
    {
        //[IgnoreJson]
        public override string Id { set; get; }

        public string Name { set; get; }
    }
}
