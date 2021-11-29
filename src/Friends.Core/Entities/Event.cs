using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using Friends.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Friends.Entities
{
    public class Event : Entity<Guid>, IHasCreationTime
    {
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public EventType EventType { get; set; }
        public DateTime CreationTime { get; set; }
        public string Location { get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        public List<UserEvent> UserEvents { get; set; }
        public PeriodicityType PeriodicityType { get; set; }
        public Event()
        {
            CreationTime = Clock.Now;
        }

    }
    public enum PeriodicityType
    {
        EveryDay, BiWeekly, OnceAWeek, OnceAMonth
    }

    public enum EventType
    {
        RoomEvent, Personal
    }
}
