using HackerrankSolutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSoutions.Tests
{
    public class FindDigitsTests
    {
        FindDigits fd = null;
        public FindDigitsTests()
        {
            fd = new FindDigits();
        }

        [Fact]
        public void test1()
        {
            Assert.Equal(2, fd.findDigits(12));
            Assert.Equal(3, fd.findDigits(1012));
        }

    }
}
