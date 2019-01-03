using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeforcesApiWrapper.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeforcesApiWrapper.Test
{
    [TestClass]
    public class BlogEntryTest
    {
        [TestMethod]
        public void CommentsTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<List<Comment>> response = codeforces.BlogEntity.Comments(79).Result;

            Assert.AreEqual("OK", response.Status);

            List<Comment> comments = response.Result;
            Assert.IsNotNull(comments);
            Assert.IsTrue(comments.Count > 0);

            Comment firstComment = comments.First();
            Assert.IsNotNull(firstComment);
            Assert.IsNotNull(firstComment.CommentatorHandle);
        }
            
        [TestMethod]
        public void ViewTest()
        {
            var codeforces = new Codeforces();
            ResponseContainer<BlogEntry> response = codeforces.BlogEntity.View(79).Result;

            Assert.AreEqual("OK", response.Status);

            BlogEntry blogEntry = response.Result;
            Assert.IsNotNull(blogEntry);
            Assert.IsFalse(string.IsNullOrEmpty(blogEntry.AuthorHandle));
        }
    }
}