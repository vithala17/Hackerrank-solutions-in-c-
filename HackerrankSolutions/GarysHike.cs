using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerrankSolutions
{

    public class GarysHike
    {
        // Complete the countingValleys function below.
        public int countingValleys(int n, string s)
        {

            int upSteps = 0, valleyCount = 0;

            bool valleyStart = false;

            foreach (char step in s)
            {
                if (step == 'U')
                    upSteps++;
                else if (step == 'D')
                    upSteps--;

                if (upSteps < 0 && valleyStart == false)
                {
                    valleyStart = true;
                }
                else if (upSteps == 0 && valleyStart == true)
                {
                    valleyCount++;
                    valleyStart = false;
                }
            }

            return valleyCount;

        }
    }
}
