using System;
using System.Collections.Generic;
using System.Text;
using testapi.Data;

namespace testapi.Framework
{
    public class CommentRepository : Repository<Comment, int, FrameworkContext>, ICommentRepository
    {
        public CommentRepository(FrameworkContext dbContext):base(dbContext)
        {
            
        }
    }
}
