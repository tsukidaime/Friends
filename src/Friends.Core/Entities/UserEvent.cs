using Abp.Domain.Values;
using Friends.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Entities
{
    public class UserEvent : ValueObject
    {
        public long UserId { get; set; }
        public Guid EventId { get; set; }
        public bool WillAttend { get; set; }
        public User User { get; set; }
        public Event Event { get; set; }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return UserId;
            yield return EventId;
            yield return WillAttend;
        }
    }
}
