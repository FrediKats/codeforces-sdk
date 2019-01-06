using System.Collections.Generic;
using CodeforcesApiWrapper.NonStandardTypes;
using CodeforcesApiWrapper.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeforcesApiWrapper.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void BlogEntriesTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<List<BlogEntry>> response = codeforces.User.BlogEntries("enosha_slexsy").Result;

            Assert.AreEqual("OK", response.Status);

            List<BlogEntry> blogEntries = response.Result;
            Assert.IsNotNull(blogEntries);
        }

        [TestMethod]
        public void InfoTest()
        {
            var codeforces = new Codeforces();
            var handles = new List<string>
            {
                "enosha_slexsy",
                "Radewoosh",
                "I_love_Tanya_Romanova"
            };
            var handlesArg = new HandlesArgument(handles);
            ResponseContainer<List<User>> response = codeforces.User.Info(handlesArg).Result;

            Assert.AreEqual("OK", response.Status);

            List<User> users = response.Result;
            Assert.IsNotNull(users);
            Assert.AreEqual(3, users.Count);
        }

        [TestMethod]
        public void RatedListTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<List<User>> response = codeforces.User.RatedList(true).Result;

            Assert.AreEqual("OK", response.Status);

            List<User> users = response.Result;
            Assert.IsNotNull(users);
        }

        [TestMethod]
        public void RatingTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<List<RatingChange>> response = codeforces.User.Rating("enosha_slexsy").Result;

            Assert.AreEqual("OK", response.Status);

            List<RatingChange> ratingChanges = response.Result;
            Assert.IsNotNull(ratingChanges);
        }

        [TestMethod]
        public void StatusTest()
        {
            const int count = 10;
            var codeforces = new Codeforces();
            ResponseContainer<List<Submission>> response = codeforces.User.Status("enosha_slexsy", 2, count).Result;

            Assert.AreEqual("OK", response.Status);

            List<Submission> submissions = response.Result;
            Assert.IsNotNull(submissions);
            Assert.AreEqual(count, submissions.Count);
        }
    }
}