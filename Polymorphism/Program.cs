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
            showOverload.PrintStringOverloadExample("Hello!");
            showOverload.PrintStringOverloadExample("Hello", "world!");
            Console.WriteLine("");

            // Override example
            ShowStringBase showOverrideExample = new ShowString1();
            Console.WriteLine("Override example");
            showOverrideExample.PrintStringOverride();
            Console.WriteLine("");

            // New example
            ShowStringBase showNewExample = new ShowString1();
            Console.WriteLine("New example");
            showNewExample.PrintStringNewExample();
            Console.WriteLine("");

            Console.WriteLine("New example with cast to derived class");
            ((ShowString1)showNewExample).PrintStringNewExample();

            Console.ReadKey();
        }
    }
}