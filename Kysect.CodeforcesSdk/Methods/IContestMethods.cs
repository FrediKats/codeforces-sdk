using System.Collections.Generic;
using System.Threading.Tasks;
using Kysect.CodeforcesSdk.NonStandardTypes;
using Kysect.CodeforcesSdk.Types;
using Refit;

namespace Kysect.CodeforcesSdk.Methods
{
    public interface IContestMethods
    {
        [Get("/contest.hacks")]
        Task<ResponseContainer<List<Hack>>> Hacks(int contestId);

        [Get("/contest.list")]
        Task<ResponseContainer<List<Contest>>> List(bool? gym = null);

        [Get("/contest.ratingChanges")]
        Task<ResponseContainer<List<RatingChange>>> RatingChanges(int contestId);

        [Get("/contest.standings")]
        Task<ResponseContainer<Standing>> Standings(int contestId, int? from = null, int? count = null,
            HandlesArgument handles = null, int? room = null, bool? showUnofficial = null);

        [Get("/contest.status")]
        Task<ResponseContainer<List<Submission>>> Status(int contestId, string handle = null, int? from = null,
            int? count = null);
    }
}