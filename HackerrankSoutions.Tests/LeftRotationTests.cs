using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using HackerrankSolutions;

namespace HackerrankSolutions.Tests
{
    public class LeftRotationTests
    {
        [Fact]
        public void rotate_test01()
        {
            LeftRotation obj = new LeftRotation();

            int[] array = new int[] { 3, 4, 5, 1, 2 };

            var result = obj.rotate(new int[] { 1, 2, 3, 4, 5 }, 3);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.Equal(array[i], result[i]);
            }
        }
    }
}
