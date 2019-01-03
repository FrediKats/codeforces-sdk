﻿using System.Collections.Generic;
using CodeforcesApiWrapper.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeforcesApiWrapper.Test
{
    [TestClass]
    public class RecentActionsTest
    {
        [TestMethod]
        public void HackTest()
        {
            const int maxCount = 10;
            var codeforces = new Codeforces();
            ResponseContainer<List<RecentAction>> response = codeforces.RecentActions.RecentActions(maxCount).Result;

            Assert.AreEqual("OK", response.Status);

            List<RecentAction> recentActions = response.Result;
            Assert.IsNotNull(recentActions);
            Assert.AreEqual(maxCount, recentActions.Count);
        }
    }
}