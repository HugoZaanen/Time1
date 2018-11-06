using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and initialize a time1 object
            var t1 = new Time2();//invokes time1 constructor
            var t2 = new Time2();// 02:00:00
            var t3 = new Time2(21,34);//21:34:00
            var t4 = new Time2(12,25,42);//12:25:42
            var t5 = new Time2(t4);//12:25:42

            Console.WriteLine("Constructoed with:\n");
            Console.WriteLine("t1: all arguments defaulted");
            Console.WriteLine($"  {t1.ToUniversalString()}");//00:00:00
            Console.WriteLine($"  {t1.ToString()}\n");//12:00:00 AM

            Console.WriteLine(
                "t2: hour specified; minute and second defaulted");
            Console.WriteLine($"  {t2.ToUniversalString()}");
            Console.WriteLine($"  {t2.ToString()}\n");

            Console.WriteLine(
                "t3: hour and minute specified: second defaulted");
            Console.WriteLine($"  {t3.ToUniversalString()}");
            Console.WriteLine($"  {t3.ToString()}");

            Console.WriteLine("t4: hour,minute and second specified");
            Console.WriteLine($"   {t4.ToUniversalString()}");
            Console.WriteLine($"   {t4.ToString()}");

            Console.WriteLine("t5: Time2 object t4 specified");
            Console.WriteLine($"   {t5.ToUniversalString()}");
            Console.WriteLine($"   {t5.ToString()}");

            //attempt to initialize t6 with invalid values
            try
            {
                var t6 = new Time2(27,74, 99);//invalid values
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\nException while initializing t6: ");
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
