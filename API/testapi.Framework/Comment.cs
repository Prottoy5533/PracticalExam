using System;
using System.Collections.Generic;
using System.Text;
using testapi.Data;

namespace testapi.Framework
{
   public class Comment : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LikeCount { get; set; }
        public int DisLikeCount { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }

    }
}
