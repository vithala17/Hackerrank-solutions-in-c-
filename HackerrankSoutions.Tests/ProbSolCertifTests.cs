using System;
using Xunit;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions.Tests
{
    public class ProbSolCertifTests
    {
        [Fact]
        public void stringAnagramTests()
        {
            ProbSolCertif certifs = new ProbSolCertif();

            var actual = certifs.stringAnagram(new List<string> { "heater", "cold", "clod", "reheat", "docl" }, new List<string> { "codl", "heater", "abcd" });

            var expected = new List<int> { 3, 2, 0 };

            for(int i=0; i < expected.Count; i++)
            {
                Assert.Equal(actual[i], expected[i]);
            }
        }
    }
}
