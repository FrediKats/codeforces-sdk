using System.Collections.Generic;
using System.Threading.Tasks;
using Kysect.CodeforcesSdk.Types;
using Refit;

namespace Kysect.CodeforcesSdk.Methods
{
    public interface IRecentActionsMethods
    {
        [Get("/recentActions")]
        Task<ResponseContainer<List<RecentAction>>> RecentActions(int maxCount);
    }
}