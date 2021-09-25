using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex();
            num1.Read();
            Complex num2 = new Complex();
            num2.Read();

            Console.WriteLine((num1 + num2).ToString());
            Console.WriteLine((num1 - num2).ToString());
            Console.WriteLine((num1 * num2).ToString());

            Console.ReadKey();
        }
    }
}
