using HackerrankSolutions;
using System.Collections.Generic;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class BetweenTwoSetsTests
    {
        BetweenTwoSets twosets = null;

        public BetweenTwoSetsTests()
        {
            twosets = new BetweenTwoSets();
        }

        [Fact]
        public void getTotalXTest()
        {
            Assert.Equal(3, BetweenTwoSets.getTotalX(new List<int>() { 2, 4 }, new List<int>() { 16, 32, 96 }));
        }

        [Fact]
        public void getGCDTests()
        {
            
        }
    }
}
