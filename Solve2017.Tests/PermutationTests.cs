using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Solve2017.Tests
{
    public class PermutationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Permutate1()
        {
            var list = new List<int> { 1 };
            var permutations = Solve2017.Solver.GetPermutations(list);
            Assert.AreEqual(1, permutations.Count());
        }

        [Test]
        public void Permutate12()
        {
            var list = new List<int> { 1, 2 };
            var permutations = Solve2017.Solver.GetPermutations(list);
            Assert.AreEqual(2, permutations.Count());
        }

        [Test]
        public void Permutate11()
        {
            var list = new List<int> { 1, 1 };
            var permutations = Solve2017.Solver.GetPermutations(list);
            Assert.AreEqual(1, permutations.Count());
        }

        [Test]
        public void Permutate123()
        {
            var list = new List<int> { 1, 2, 3 };
            var permutations = Solve2017.Solver.GetPermutations(list);
            Assert.AreEqual(6, permutations.Count());
        }

        [Test]
        public void Permutate121()
        {
            var list = new List<int> { 1, 2, 1 };
            var permutations = Solve2017.Solver.GetPermutations(list);
            Assert.AreEqual(3, permutations.Count());
        }

        [Test]
        public void Permutate1234()
        {
            var list = new List<int> { 1, 2, 3, 4 };
            var permutations = Solve2017.Solver.GetPermutations(list);
            Assert.AreEqual(24, permutations.Count());
        }

        [Test]
        public void Permutate1231()
        {
            var list = new List<int> { 1, 2, 3, 1 };
            var permutations = Solve2017.Solver.GetPermutations(list);
            Assert.AreEqual(12, permutations.Count());
        }

        [Test]
        public void Permutate1212()
        {
            var list = new List<int> { 1, 2, 1, 2 };
            var permutations = Solve2017.Solver.GetPermutations(list);
            Assert.AreEqual(6, permutations.Count());
        }
    }
}