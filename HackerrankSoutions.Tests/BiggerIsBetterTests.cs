using System;
using System.Collections.Generic;
using System.Text;
using HackerrankSolutions;
using Xunit;

namespace HackerrankSoutions.Tests
{
    public class BiggerIsBetterTests
    {
        BiggerIsBetter Bib = null;
        public BiggerIsBetterTests()
        {
            Bib = new BiggerIsBetter();
        }

        [Fact]
        public void test1()
        {
            Assert.Equal("fedcbabdc", Bib.biggerIsGreater("fedcbabcd"));
        }
    }
}
