using HackerrankSolutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class BeautifulTripletsTests
    {
        BeautifulTriplets bt = null;

        public BeautifulTripletsTests()
        {
            bt = new BeautifulTriplets();
        }

        [Fact]
        public void test1()
        {
            Assert.Equal(3, bt.beautifulTriplets(3, new int[] { 1, 2, 4, 5, 7, 8, 10 }));
        }
    }
}
