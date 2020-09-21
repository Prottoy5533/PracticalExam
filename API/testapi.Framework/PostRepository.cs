using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using testapi.Data;

namespace testapi.Framework
{
   public class PostRepository : Repository<Post, int, FrameworkContext>, IPostRepository
    {
        public PostRepository(FrameworkContext dbContext) : base(dbContext)
        {
            
        }

        
    }
}
