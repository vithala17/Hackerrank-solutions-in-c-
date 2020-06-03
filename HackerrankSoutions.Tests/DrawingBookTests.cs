using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class DrawingBookTests
    {
        [Fact]
        public void Test1()
        {
            DrawingBook db = new DrawingBook();
            var actual = db.pageCount(5, 4);
            var expected = 1;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            DrawingBook db = new DrawingBook();
            var actual = db.pageCount(100, 96);
            var expected = 2;

            Assert.Equal(expected, actual);
        }
    }
}
