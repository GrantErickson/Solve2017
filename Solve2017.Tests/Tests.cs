using NUnit.Framework;

namespace Solve2017.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test2017()
        {
            var result = Solver.Solve(2017);
            Assert.AreEqual(97, result.Count);
        }

        [Test]
        public void Test123()
        {
            var result = Solver.Solve(123);
            Assert.AreEqual(67, result.Count);
        }

        [Test]
        public void Test1234()
        {
            var result = Solver.Solve(1234);
            Assert.AreEqual(100, result.Count);
        }

    }
}