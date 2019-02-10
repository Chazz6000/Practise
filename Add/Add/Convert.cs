using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Convert
    {

        private  int _num1 { get; set; }
        private int _num2 { get; set; }
        private int _result { get; set; }

        public Convert(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;

            _result = _num1 + _num2;

            Console.WriteLine("Your total is " + _result);

        }

        
              
    }


    
}
