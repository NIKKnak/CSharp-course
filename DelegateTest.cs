using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{


    delegate void MyDelegate();
    internal class DelegateTest
    {

        public static void Print()
        {
            Console.WriteLine("Test");
        }
        public static void Print1()
        {
            Console.WriteLine("Test");
        }
        public static void Print2()
        {
            Console.WriteLine("Test");
        }
        public static void Print4()
        {
            Print1();
            Print2();
            Print();
        }
    }
}
