using System;
using System.Collections.Generic;
using System.Text;

namespace testapi.Framework
{
    public class PostData
    {
        public IList<PostDto> PostDtos { get; set; }
        public int TotalCount { get; set; }
        public int TotalDisplay { get; set; }

    }
}
