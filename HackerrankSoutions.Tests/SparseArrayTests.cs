using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRankProblems.Tests
{
    public class SparseArrayTests
    {
        [Fact]
        public void matchinString_Test01()
        {
            SparseArrays obj = new SparseArrays();

            var expected = new int[] { 2, 1, 0 };
            var actual = obj.matchingStrings(new string[] { "aba", "baba", "aba", "xzxb" }, new string[] { "aba", "xzxb", "ab" });

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.Equal(actual[i], expected[i]);
            }
        }
    }
}
