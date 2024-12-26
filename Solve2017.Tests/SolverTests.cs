using NUnit.Framework;

namespace Solve2017.Tests
{
    public class SolverTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test2017()
        {
            var result = Solver.Solve("2017");
            Assert.AreEqual(97, result.Count);
        }

        [Test]
        public void Test12()
        {
            var result = Solver.Solve("12");
            Assert.AreEqual(10, result.Count);
        }

        [Test]
        public void Test2018()
        {
            var result = Solver.Solve("2018");
            Assert.AreEqual(99, result.Count);
        }

        [Test]
        public void Test2019()
        {
            var result = Solver.Solve("2019");
            Assert.AreEqual(100, result.Count);
        }

        [Test]
        public void Test2020()
        {
            var result = Solver.Solve("2020");
            Assert.AreEqual(75, result.Count);
        }

        [Test]
        public void Test2021()
        {
            var result = Solver.Solve("2021");
            Assert.AreEqual(81, result.Count);
        }

        [Test]
        public void Test123()
        {
            var result = Solver.Solve("123");
            Assert.AreEqual(67, result.Count);
        }

        [Test]
        public void Test1234()
        {
            var result = Solver.Solve("1234");
            Assert.AreEqual(100, result.Count);
        }

    }
}