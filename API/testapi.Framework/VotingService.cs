using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace testapi.Framework
{
    public class VotingService : IVotingService
    {
        private readonly IVoteUnitOfWork _voteUnitOfWork;
        public VotingService(IVoteUnitOfWork voteUnitOfWork)
        {
            _voteUnitOfWork = voteUnitOfWork;
        }

        public (IList<PostDto> postDtos, int total, int totalDisplay) GetData(int pageIndex, int pageSize, string searchText, string sortText)
        {
            
            var (posts,total,totalDisplay) =
                _voteUnitOfWork.PostRepository.GetDynamic(p=>(searchText==null ? true : p.Name.Contains(searchText)), sortText, c => c.Include(a => a.Comments), pageIndex,
                    pageSize, true);
            var postList = new List<PostDto>();
            foreach (var newdata in posts)
            {
                var post = new PostDto
                {
                    Id = newdata.Id,
                    Name = newdata.Name,
                    CreatedBy = newdata.CreatedBy,
                    CreatedOn = newdata.CreatedOn,
                    CommentDtos = new List<CommentDto>()
                };

                foreach (var comment in newdata.Comments)
                {
                    
                    post.CommentDtos.Add(new CommentDto
                    {
                        Id = comment.Id,
                        Name = comment.Name,
                        CreatedOn = comment.CreatedOn,
                        CreatedBy = comment.CreatedBy,
                        LikeCount = comment.LikeCount,
                        DisLikeCount = comment.DisLikeCount,


                    });
                }
                postList.Add(post);
            }

            return (postList,total,totalDisplay);

        }

        public void Dispose()
        {
            _voteUnitOfWork?.Dispose();
        }
    }
}
