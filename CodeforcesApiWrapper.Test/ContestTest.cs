using System.Collections.Generic;
using System.Linq;
using CodeforcesApiWrapper.NonStandardTypes;
using CodeforcesApiWrapper.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeforcesApiWrapper.Test
{
    [TestClass]
    public class ContestTest
    {
        [TestMethod]
        public void HackTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<List<Hack>> response = codeforces.Contest.Hacks(556).Result;

            Assert.AreEqual("OK", response.Status);

            List<Hack> hacks = response.Result;
            Assert.IsNotNull(hacks);
            Assert.IsTrue(hacks.Count > 0);

            Hack firstHack = hacks.First();
            Assert.IsNotNull(firstHack);
            Assert.IsNotNull(firstHack.Hacker);
            Assert.IsNotNull(firstHack.Problem);
            Assert.IsNotNull(firstHack.Defender);
            Assert.IsNotNull(firstHack.Test);
        }

        [TestMethod]
        public void ListTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<List<Contest>> response = codeforces.Contest.List().Result;

            Assert.AreEqual("OK", response.Status);

            List<Contest> contests = response.Result;
            Assert.IsNotNull(contests);

            Contest firstContest = contests.First();
            Assert.IsNotNull(firstContest);
            Assert.IsNotNull(firstContest.Phase);
            Assert.IsNotNull(firstContest.Name);
        }

        [TestMethod]
        public void ListWithGymTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<List<Contest>> response = codeforces.Contest.List(true).Result;

            Assert.AreEqual("OK", response.Status);

            List<Contest> contests = response.Result;
            Assert.IsNotNull(contests);
            //TODO: Check if any gym in list
        }

        [TestMethod]
        public void RatingChangesTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<List<RatingChange>> response = codeforces.Contest.RatingChanges(556).Result;

            Assert.AreEqual("OK", response.Status);

            List<RatingChange> changes = response.Result;
            Assert.IsNotNull(changes);

            RatingChange firstChange = changes.First();
            Assert.IsNotNull(firstChange.ContestName);
            Assert.IsNotNull(firstChange.Handle);
        }

        [TestMethod]
        public void StandingsTest()
        {
            var codeforces = new Codeforces();
            const int elementCount = 10;
            ResponseContainer<Standing> response =
                codeforces.Contest.Standings(556, 2, count: elementCount, showUnofficial: true).Result;

            Assert.AreEqual("OK", response.Status);

            Standing standing = response.Result;
            Assert.IsNotNull(standing);
            Assert.IsNotNull(standing.Contest);
            Assert.IsNotNull(standing.Problems);
            Assert.IsNotNull(standing.Rows);
            Assert.AreEqual(elementCount, standing.Rows.Count);
        }

        [TestMethod]
        public void StatusTest()
        {
            var codeforces = new Codeforces();
            const int elementCount = 10;
            ResponseContainer<List<Submission>> response =
                codeforces.Contest.Status(556, from: 2, count: elementCount).Result;

            Assert.AreEqual("OK", response.Status);

            List<Submission> submissions = response.Result;
            Assert.IsNotNull(submissions);
            Assert.AreEqual(elementCount, submissions.Count);

            Submission submission = submissions.First();
            Assert.IsNotNull(submission.Problem);
            Assert.IsNotNull(submission.Author);
            Assert.IsNotNull(submission.Problem);
        }
    }
}