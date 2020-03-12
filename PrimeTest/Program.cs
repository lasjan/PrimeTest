using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int startIndex;
                int endIndex;

                Console.WriteLine("*** Prime seek ***");
                Console.WriteLine("Please enter start index..");

                var startInput = Console.ReadLine();
                startIndex = ParseUtils.ParseArg(startInput);

                Console.WriteLine("Please enter end index..");
                
                var endInput = Console.ReadLine();
                endIndex = ParseUtils.ParseArg(endInput);

                if (startIndex >=endIndex)
                {
                    throw new ArgumentException(String.Format(ParseUtils.ERR_START_HIGHER_THAN_END, startIndex, endIndex));
                }

                Console.WriteLine(String.Format("Parsing range from {0} and {1}", startInput, endInput));

                ParseUtils.ProcessRange(startIndex, endIndex, (v) => { Console.WriteLine(v); });
            }
            catch(ArgumentException aex)
            {
                Console.WriteLine("Argument exception.." + aex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unexpected exception.." + ex.Message);

            }
            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
