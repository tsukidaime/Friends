using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Entities
{
    public class Room : Entity<Guid>, IHasCreationTime
    {
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public Access Access { get; set; }
        public List<Event> Events { get; set; }
        public List<UserRoom> UserRooms { get; set; }
        public Room()
        {
            CreationTime = Clock.Now;
        }
    }

    public enum Access
    {
        Private, Public 
    }
}
