using System;
using System.Linq;

namespace NunitSampleLibrary
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        public int Substract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Device(int a, int b)
        {
            return a / b;
        }
    }
}
