using System.Collections.Generic;
using System.Threading.Tasks;
using CodeforcesApiWrapper.Types;
using Refit;

namespace CodeforcesApiWrapper.Methods
{
    public interface IRecentActionsMethods
    {
        [Get("/recentActions")]
        Task<ResponseContainer<List<RecentAction>>> RecentActions(int maxCount);
    }
}