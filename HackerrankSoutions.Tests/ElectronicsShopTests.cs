using System;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class ElectronicsShopTests
    {
        [Fact]
        public void Test1()
        {
            ElectronicsShop eshop = new ElectronicsShop();
            var actual = eshop.getMoneySpent(new int[]{3, 1}, new int[] { 5, 2, 8 }, 10);

            int expected = 9;

            Assert.Equal(actual, expected);
        }
    }
}
