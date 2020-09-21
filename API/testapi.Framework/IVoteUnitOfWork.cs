using System;
using System.Collections.Generic;
using System.Text;
using testapi.Data;

namespace testapi.Framework
{
    public interface IVoteUnitOfWork : IUnitOfWork
    {
        ICommentRepository CommentRepository { get; set; }
        IPostRepository PostRepository { get; set; }
    }
}
