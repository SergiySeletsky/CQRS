using Product.Domain.Core.Domain;
using Product.Domain.ReadModel.Events;
using Product.Domain.WriteModel.Commands;
using System;

namespace Product.Domain.WriteModel.Domain
{
    public class User : AggregateRoot
    {
        private User() { }
        public User(Guid id, string name)
        {
            Id = id;
            ApplyChange(new UserCreatedEvent());
        }

        private void Apply(UserCreatedEvent e)
        {

        }
    }
}
