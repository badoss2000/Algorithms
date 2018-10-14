using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms
{
    public class Factorial
    {
        public ulong FactorialUsingRecursion(ulong factorial)
        {
            if (factorial <= 1) return 1; // the factorial value for 0 and 1 is 1
            return factorial * FactorialUsingRecursion(factorial - 1);
        }
    }
}
