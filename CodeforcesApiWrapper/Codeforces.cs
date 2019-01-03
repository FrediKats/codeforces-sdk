using CodeforcesApiWrapper.Methods;
using Refit;

namespace CodeforcesApiWrapper
{
    public class Codeforces
    {
        private const string ApiUrl = "http://codeforces.com/api";

        public Codeforces()
        {
            BlogEntity = RestService.For<IBlogEntityMethods>(ApiUrl);
            Contest = RestService.For<IContestMethods>(ApiUrl);
            ProblemSet = RestService.For<IProblemSetMethods>(ApiUrl);
            RecentActions = RestService.For<IRecentActionsMethods>(ApiUrl);
            User = RestService.For<IUserMethods>(ApiUrl);
        }

        public IBlogEntityMethods BlogEntity { get; }
        public IContestMethods Contest { get; }
        public IProblemSetMethods ProblemSet { get; }
        public IRecentActionsMethods RecentActions { get; }
        public IUserMethods User { get; }
    }
}