using System;

namespace nothinbutdotnetprep
{
    public class BaseCalculator : Calculator
    {
        public int add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int subtract(int i, int i1)
        {
            throw new NotImplementedException();
        }
    }
}