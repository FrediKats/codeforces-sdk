using System.Collections.Generic;
using CodeforcesApiWrapper.NonStandartTypes;
using CodeforcesApiWrapper.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeforcesApiWrapper.Test
{
    [TestClass]
    public class ProblemSetTest
    {
        [TestMethod]
        public void ProblemsTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<ProblemsMethodResponse> response =
                codeforces.ProblemSet.Problems("acmsguru").Result;

            Assert.AreEqual("OK", response.Status);

            ProblemsMethodResponse data = response.Result;
            Assert.IsNotNull(data.ProblemStatistics);
            Assert.IsNotNull(data.Problems);
        }

        [TestMethod]
        public void RecentStatusTest()
        {
            const int elementsCount = 10;
            var codeforces = new Codeforces();
            ResponseContainer<List<Submission>> response =
                codeforces.ProblemSet.RecentStatus(elementsCount, "acmsguru").Result;

            Assert.AreEqual("OK", response.Status);

            List<Submission> submissions = response.Result;
            Assert.IsNotNull(submissions);
            Assert.AreEqual(elementsCount, submissions.Count);
        }
    }
}