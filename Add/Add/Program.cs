using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Second number ");
            int num2 = Int32.Parse(Console.ReadLine());

            Convert convert = new Convert(num1, num2);
        

            
            
        }
    }
}
