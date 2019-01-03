using System.Collections.Generic;
using System.Threading.Tasks;
using CodeforcesApiWrapper.Types;
using Refit;

namespace CodeforcesApiWrapper.Methods
{
    public interface IBlogEntityMethods
    {
        [Get("/blogEntry.comments")]
        Task<ResponseContainer<List<Comment>>> Comments(int blogEntryId);

        [Get("/blogEntry.view")]
        Task<ResponseContainer<BlogEntry>> View(int blogEntryId);
    }
}
