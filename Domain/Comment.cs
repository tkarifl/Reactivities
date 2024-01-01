using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public AppUser Author { get; set; }
        public Activity Activity { get; set; }
        //wherever they sent the comment from the world, it will be stored as utc time in our database
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}