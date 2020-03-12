using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTest
{
    public static class ParseUtils
    {
        public static readonly string ERR_NOT_NUMBER = "Value '{0}' could not be parsed as integer..";
        public static readonly string ERR_NON_POSITIVE = "Value '{0}' should be greater or equal 0.";
        public static readonly string ERR_START_HIGHER_THAN_END = "Start index '{0}' should be lower than end index '{1}'";

        public static bool CheckIfPrime(int value)
        {
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public  static void ProcessRange(int startIndex, int endIndex, Action<string> action)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (CheckIfPrime(i))
                {
                    action(i.ToString());
                }
            }
        }
        public static int ParseArg(string input)
        {
            int index;
            if (!Int32.TryParse(input, out index))
            {
                throw new ArgumentException(String.Format(ERR_NOT_NUMBER, input));
            }
            if (index <= 0)
            {
                throw new ArgumentException(String.Format(ERR_NON_POSITIVE, index));
            }

            return index;

        }
    }
}
