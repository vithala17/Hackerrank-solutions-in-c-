using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class TaumBdayTests
    {
        TaumBday obj = null;

        public TaumBdayTests()
        {
            obj = new TaumBday();
        }

        [Fact]
        public void test1()
        {
            Assert.Equal(29, obj.taumBday(3, 5, 3, 4, 1));
        }

        [Fact]
        public void test2()
        {
            Assert.Equal(20, obj.taumBday(10, 10, 1, 1, 1));
        }

        [Fact]
        public void test3()
        {
            Assert.Equal(37, obj.taumBday(5, 9, 2, 3, 4));
        }

        [Fact]
        public void test4()
        {
            Assert.Equal(12, obj.taumBday(3, 6, 9, 1, 1));
        }

        [Fact]
        public void test5()
        {
            Assert.Equal(35, obj.taumBday(7, 7, 4, 2, 1));
        }

        [Fact]
        public void test6()
        {
            Assert.Equal(12, obj.taumBday(3, 3, 1, 9, 2));
        }

        [Fact]
        public void test7()
        {
            Assert.Equal(18192035842, obj.taumBday(27984, 1402, 619246, 615589, 247954));
        }
    }
}
