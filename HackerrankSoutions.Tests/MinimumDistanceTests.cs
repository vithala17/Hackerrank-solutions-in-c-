using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class MinimumDistanceTests
    {
        MinimumDistance md = null;
        public MinimumDistanceTests()
        {
            md = new MinimumDistance();
        }

        [Fact]
        public void test1()
        {
            Assert.Equal(3, md.minimumDistances(new int[] { 7, 1, 3, 4, 1, 7}));
        }
    }
}
