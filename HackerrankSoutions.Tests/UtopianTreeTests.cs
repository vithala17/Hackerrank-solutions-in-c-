using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class UtopianTreeTests
    {
        [Fact]
        public void Test1()
        {
            UtopianTree tree = new UtopianTree();
            var actual = tree.utopianTree(4);
            var expected = 7;
            Assert.Equal(expected, actual);
        }
    }
}
