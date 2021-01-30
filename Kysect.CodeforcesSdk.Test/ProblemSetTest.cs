using System.Collections.Generic;
using Kysect.CodeforcesSdk.NonStandardTypes;
using Kysect.CodeforcesSdk.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kysect.CodeforcesSdk.Test
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
        public void ProblemsTagsTest()
        {
            var codeforces = new Codeforces();
            var tags = new List<string>
            {
                "implementation",
                "math"
            };
            var tagsArgument = new TagsArgument(tags);

            ResponseContainer<ProblemsMethodResponse> response =
                codeforces.ProblemSet.Problems(tags: tagsArgument).Result;

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