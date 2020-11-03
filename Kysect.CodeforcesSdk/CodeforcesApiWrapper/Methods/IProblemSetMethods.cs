using System.Collections.Generic;
using System.Threading.Tasks;
using CodeforcesApiWrapper.NonStandardTypes;
using CodeforcesApiWrapper.Types;
using Refit;

namespace CodeforcesApiWrapper.Methods
{
    public interface IProblemSetMethods
    {
        [Get("/problemset.problems")]
        Task<ResponseContainer<ProblemsMethodResponse>> Problems(string problemsetName = null, TagsArgument tags = null);

        [Get("/problemset.recentStatus")]
        Task<ResponseContainer<List<Submission>>> RecentStatus(int count, string problemsetName = null);
    }
}