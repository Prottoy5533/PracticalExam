using System;
using System.Collections.Generic;
using System.Text;
using testapi.Data;

namespace testapi.Framework
{
    public class Post : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
