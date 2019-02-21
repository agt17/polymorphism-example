using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ShowString1 : ShowStringBase
    {
        public override void PrintStringOverloadExample(string message)
        {
            Console.WriteLine("Message 1: " + message);
        }

        public void PrintStringOverloadExample(string message1, string message2)
        {
            Console.WriteLine("Other message 1: " + message1 + " " + message2);
        }

        public new void PrintStringNewExample()
        {
            Console.WriteLine("Message from derived class");
        }

        public override void PrintStringOverride()
        {
            Console.WriteLine("Message with override at derived class");
        }
    }
}
