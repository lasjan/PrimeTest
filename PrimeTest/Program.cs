using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTest
{
    class Program
    {
        static bool CheckIfPrime(int value)
        {
            for(int i = 0; i < value; i++)
            {
                if(i%value == 0 )
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
