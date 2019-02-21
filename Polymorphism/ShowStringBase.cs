using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ShowStringBase
    {
        public virtual void PrintString(string message)
        {
            Console.WriteLine("Base class message: " + message);
        }

        public void PrintStringNewExample()
        {
            Console.WriteLine("Message from base class");
        }
    }
}
