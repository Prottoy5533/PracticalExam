using System;
using System.Collections.Generic;
using System.Text;
using testapi.Data;

namespace testapi.Framework
{
    public interface ICommentRepository : IRepository<Comment, int, FrameworkContext>
    {
    }
}
