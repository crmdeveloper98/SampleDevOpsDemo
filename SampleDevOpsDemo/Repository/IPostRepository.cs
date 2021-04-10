using SampleDevOpsDemo.Models;
using System.Collections.Generic;

namespace SampleDevOpsDemo.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
