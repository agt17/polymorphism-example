using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowString1 showOverload = new ShowString1();
            // Overload Example
            Console.WriteLine("Overload example");
            showOverload.PrintString("Hello!");
            showOverload.PrintString("Hello", "world!");

            // New example
            ShowStringBase showNewExample = new ShowString1();
            Console.WriteLine("New example");
            showNewExample.PrintStringNewExample();

            /*
            ShowStringBase showString;
            showString = new ShowString1();
            showString.PrintString("Hello!");

            showString = new ShowString2();
            showString.PrintString("Hello!");
            */
        }
    }
}