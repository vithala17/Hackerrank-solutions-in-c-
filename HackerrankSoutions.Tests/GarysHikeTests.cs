using Xunit;

namespace HackerrankSolutions.Tests
{
    public class GarysHikeTests
    {

        [Fact]
        public void test1()
        {
            //Arrange
            int expected = 1;
            GarysHike gh = new GarysHike();
            
            //Act
            int actual = gh.countingValleys(8, "UDDDUDUU");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
