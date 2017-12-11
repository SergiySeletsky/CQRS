using System;

namespace Product.Domain.Core.Events
{
    public abstract class Event : IEvent
    {
        public Guid Id { get; set; }

        public int Version { get; set; }

        /// <summary>
        /// Date and time when event was created
        /// </summary>
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
