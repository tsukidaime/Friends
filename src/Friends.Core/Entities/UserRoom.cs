using Abp.Domain.Values;
using Friends.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Entities
{
    public class UserRoom : ValueObject
    {
        public long UserId { get; set; }
        public Guid RoomId { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return UserId;
            yield return RoomId;
        }
    }
}