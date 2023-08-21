using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    //we didn't want to let the entity framework automatically set the many-to-many relationship with our
    //activity and appuser class, because it just creates a table with only their primary keys.
    //we want to have more properties/columns on our join table so we manually create the model/class here
    public class ActivityAttendee
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Guid AcvitityId { get; set; }
        public Activity Activity { get; set; }
        public bool IsHost { get; set; }
    }
}