using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class BeautifulDaysAtMoviesTests
    {
        BeautifulDaysAtMovies obj = null;

        public BeautifulDaysAtMoviesTests()
        {
            obj = new BeautifulDaysAtMovies();
        }

        [Fact]
        public void test1()
        {
            Assert.Equal(2, obj.beautifulDays(20, 23, 6));
        }

        [Fact]
        public void test2()
        {
            Assert.Equal(21841, obj.beautifulDays(123, 456789, 189));
        }
    }
}
