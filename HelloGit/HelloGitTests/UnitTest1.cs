using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloGit;

namespace HelloGitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStefanReverse()
        {
            string input1 = "Stefan";
            string response = ReverseTask.ReverseUebung(input1);
            Assert.AreEqual("Stefan", response);

        }

        [TestMethod]
        public void TeststefanReverse()
        {
            string input1 = "stefan";
            string response = ReverseTask.ReverseUebung(input1);
            Assert.AreEqual("stefan", response);

        }

        [TestMethod]
        public void TestNormalReverse()
        {
            string input = "Hans";
            string response = ReverseTask.ReverseUebung(input);
            Assert.AreEqual("snaH", response);

        }

    }
}
