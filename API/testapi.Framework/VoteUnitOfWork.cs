using System;
using System.Collections.Generic;
using System.Text;
using testapi.Data;

namespace testapi.Framework
{
   public class VoteUnitOfWork : UnitOfWork,IVoteUnitOfWork
    {
        public IPostRepository PostRepository { get; set; }
        public ICommentRepository CommentRepository { get; set; }

        public VoteUnitOfWork(FrameworkContext context, IPostRepository postRepository, ICommentRepository commentRepository):base(context)
        {
            PostRepository = postRepository;
            CommentRepository = commentRepository;

        }
    }
}
