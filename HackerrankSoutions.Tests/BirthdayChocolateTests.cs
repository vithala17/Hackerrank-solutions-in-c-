using System;
using HackerrankSolutions;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class BirthdayChocolateTests
    {
        [Fact]
        public void birthdayTests()
        {
            BirthdayChocolate chocolate = new BirthdayChocolate();
            Assert.Equal(2, chocolate.birthday(new List<int>() { 1, 2, 1, 3, 2 }, 3, 2));
        }

    }
}
