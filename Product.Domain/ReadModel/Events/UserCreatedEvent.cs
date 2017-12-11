using Product.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.ReadModel.Events
{
    public class UserCreatedEvent : Event
    {
        public string Name { get; set; }
    }
}
