using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dojo.FizzBuzz.Rules
{
    public class FizzBuzzRule3 : IFizzBuzzRule
    {
        public string Result { get; private set; }

        public bool Parse(int i)
        {
            if (i % 3 == 0)
            {
                Result = "Fizz";
                return true;
            }
            Result = i.ToString();
            return false;
        }
    }

    public class FizzBuzzRule35 : IFizzBuzzRule
    {
        public string Result { get; private set; }

        public bool Parse(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Result = "FizzBuzz";
                return true;
            }
            Result = i.ToString();
            return false;
        }
    }

    public class FizzBuzzRule5 : IFizzBuzzRule
    {
        public string Result { get; private set; }

        public bool Parse(int i)
        {
            if (i % 5 == 0)
            {
                Result = "Buzz";
                return true;
            }
            Result = i.ToString();
            return false;
        }
    }
}