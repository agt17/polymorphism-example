using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ShowString1 : ShowStringBase
    {
        public override void PrintString(string message)
        {
            Console.WriteLine("Message 1: " + message);
        }

        public void PrintString(string message1, string message2)
        {
            Console.WriteLine("Other message 1: " + message1 + " " + message2);
        }

        public new void PrintStringNewExample()
        {
            Console.WriteLine("Message from extended class");
        }
    }
}
