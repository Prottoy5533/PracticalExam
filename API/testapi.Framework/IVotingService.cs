using System;
using System.Collections.Generic;
using System.Text;

namespace testapi.Framework
{
    public interface IVotingService : IDisposable
    {
        (IList<PostDto> postDtos, int total, int totalDisplay) GetData(int pageIndex, int pageSize, string searchText, string sortText);
    }
}
