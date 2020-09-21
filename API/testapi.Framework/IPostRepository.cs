using System;
using System.Collections.Generic;
using System.Text;
using testapi.Data;

namespace testapi.Framework
{
    public interface IPostRepository : IRepository<Post, int, FrameworkContext>
    {
    }
}
