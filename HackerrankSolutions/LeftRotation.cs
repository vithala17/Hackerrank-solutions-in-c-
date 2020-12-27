using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class LeftRotation
    {
        public List<int> rotate(int[] input, int rotations)
        {

            List<int> container = new List<int>();

            // Array.Copy(input, (rotations % input.Length), container, 0, input.Length);

            for (int i = (rotations % input.Length)-1; i < input.Length; i++)
            {
                container.Add(input[i]);
            }

            for (int i = 0; i < (rotations % input.Length) - 1; i++)
            {
                container.Add(input[i]);
            }

            return container;
        }
    }
}
