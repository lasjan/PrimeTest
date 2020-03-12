using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTest
{
    class Program
    {
        static readonly string ERR_NOT_NUMBER = "Value '{0}' could not be parsed as integer..";
        static readonly string ERR_START_HIGHER_THAN_END = "Start index '{0}' is lower than end index '{1}'";

        static bool CheckIfPrime(int value)
        {
            for(int i = 2;  i < value; i++)
            {
                if(value % i == 0 )
                {
                    return false;
                }
            }
            return true;
        }
        static void ProcessRange(int startIndex, int endIndex, Action<string> action)
        {
            for(int i = startIndex; i <= endIndex; i++)
            {
                if(CheckIfPrime(i))
                {
                    action(i.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int startIndex;
                int endIndex;

                Console.WriteLine("*** Prime seek ***");
                Console.WriteLine("Please enter start index..");

                var startInput = Console.ReadLine();
                if (!Int32.TryParse(startInput, out startIndex))
                {
                    throw new ArgumentException(String.Format(ERR_NOT_NUMBER, startInput));
                }
                Console.WriteLine("Please enter end index..");
                var endtInput = Console.ReadLine();
                if (!Int32.TryParse(endtInput, out endIndex))
                {
                    throw new ArgumentException(String.Format(ERR_NOT_NUMBER, endIndex));
                }
                ProcessRange(startIndex, endIndex, (v) => { Console.WriteLine(v); });
            }
            catch(ArgumentException aex)
            {

            }
            catch(Exception ex)
            {

            }
            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
