using System.Collections.Generic;
using System.Threading.Tasks;
using Kysect.CodeforcesSdk.Types;
using Refit;

namespace Kysect.CodeforcesSdk.Methods
{
    public interface IBlogEntityMethods
    {
        [Get("/blogEntry.comments")]
        Task<ResponseContainer<List<Comment>>> Comments(int blogEntryId);

        [Get("/blogEntry.view")]
        Task<ResponseContainer<BlogEntry>> View(int blogEntryId);
    }
}
