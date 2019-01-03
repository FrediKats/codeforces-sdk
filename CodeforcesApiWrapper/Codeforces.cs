using CodeforcesApiWrapper.Methods;
using Refit;

namespace CodeforcesApiWrapper
{
    public class Codeforces
    {
        public Codeforces()
        {
            BlogEntity = RestService.For<IBlogEntityMethods>("http://codeforces.com/api");
            Contest = RestService.For<IContestMethods>("http://codeforces.com/api");
        }

        public IBlogEntityMethods BlogEntity { get; }
        public IContestMethods Contest { get; }
    }
}