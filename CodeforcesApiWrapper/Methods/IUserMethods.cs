using System.Collections.Generic;
using System.Threading.Tasks;
using CodeforcesApiWrapper.NonStandardTypes;
using CodeforcesApiWrapper.Types;
using Refit;

namespace CodeforcesApiWrapper.Methods
{
    public interface IUserMethods
    {
        [Get("/user.blogEntries")]
        Task<ResponseContainer<List<BlogEntry>>> BlogEntries(string handle);

        //TODO: Add user.friends

        [Get("/user.info")]
        Task<ResponseContainer<List<User>>> Info(HandlesArgument handles);

        [Get("/user.ratedList")]
        Task<ResponseContainer<List<User>>> RatedList(bool? activeOnly = null);

        [Get("/user.rating")]
        Task<ResponseContainer<List<RatingChange>>> Rating(string handle);

        [Get("/user.status")]
        Task<ResponseContainer<List<Submission>>> Status(string handle, int? from = null, int? count = null);
    }
}