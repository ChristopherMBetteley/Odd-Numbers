using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            
            for(number = 1; number <= 99; number += 2)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
