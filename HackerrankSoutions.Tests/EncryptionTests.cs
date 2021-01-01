using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class EncryptionTests
    {
        Encryption enc = null;

        public EncryptionTests()
        {
            enc = new Encryption();
        }

        [Fact]
        public void test1()
        {
            string expected = "isieae fdtonf fotrga anoyec cttctt tfhhhs";
            string actual = enc.encryption("iffactsdontfittotheorychangethefacts");

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void test2()
        {
            string expected = "wmgjpnull cyjqlejgi lyhhdzbui wctlsqsbm fxeoxmsvv ovxjeirfm zadysxbhn nxkkbffpn bawobphfy";
            string actual = enc.encryption("wclwfoznbmyycxvaxagjhtexdkwjqhlojykopldsxesbbnezqmixfpujbssrbfhlgubvfhpfliimvmnny");

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void test3()
        {
            string expected = "wmgjpnull cyjqlejgi lyhhdzbui wctlsqsbm fxeoxmsvv ovxjeirfm zadysxbhn nxkkbffpn bawobphfy";
            string actual = enc.encryption("wclwfoznbmyycxvaxagjhtexdkwjqhlojykopldsxesbbnezqmixfpujbssrbfhlgubvfhpfliimvmnny");

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void test4()
        {
            string expected = "hae and via ecy";
            string actual = enc.encryption("haveaniceday");

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void test5()
        {
            string expected = "fto ehg ee dd";
            string actual = enc.encryption("feedthedog");

            Assert.Equal(expected, actual);
        }
    }
}
