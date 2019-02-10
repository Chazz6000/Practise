using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Convert
    {
        public  float origin;
        public float newnum;

        public Convert()
        {
            ApplicationStart();
        }

        public void Calculation(float origin, float newnum)
        {
            if(newnum > origin)
            {
                Increase(origin, newnum);
            }
            else
            {
                Decrease(origin, newnum);
            }
        }

     public void ApplicationStart()
        {
            int num1;
            int num2;
            Console.WriteLine("Please Enter Original number");
            num1 = Int32.Parse(Console.ReadLine());
            origin = num1;
            Console.WriteLine("Please Enter the new number ");
            num2 = Int32.Parse(Console.ReadLine());
            newnum = num2;
            Calculation(origin, newnum);

        }
        
        
        public void Increase(float origin, float newnum)
        {



            //Console.WriteLine("Increase called");
            float difference;
            float result;
            difference = newnum - origin;
            result = difference / origin * 100;
            Console.WriteLine("This is an increase of {0}%", result.ToString("0."));
            



        }

        public void Decrease(float origin, float newnum)
        {
            //Console.WriteLine("Decrease called");
            float difference;
            float result;
            difference = origin - newnum;
            result = difference / origin * 100;
            Console.WriteLine("This is a Decrease of {0}%", result.ToString("0."));
        }


    }
}
