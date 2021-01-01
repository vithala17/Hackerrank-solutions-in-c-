using System;
using System.Linq;
using System.Collections.Generic;
using HackerrankSolutions;

namespace HakcerrankSolution_DebugConsole
{
    public class box
    {
        public int index;
        public int value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Encryption enc = new Encryption();
            //Console.WriteLine(enc.encryption("wclwfoznbmyycxvaxagjhtexdkwjqhlojykopldsxesbbnezqmixfpujbssrbfhlgubvfhpfliimvmnny"));
            enc.encryption("wclwfoznbmyycxvaxagjhtexdkwjqhlojykopldsxesbbnezqmixfpujbssrbfhlgubvfhpfliimvmnny");
        }
    }
}