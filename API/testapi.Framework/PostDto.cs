using System;
using System.Collections.Generic;
using System.Text;

namespace testapi.Framework
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public IList<CommentDto> CommentDtos { get; set; }
    }
}
