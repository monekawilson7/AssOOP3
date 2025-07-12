using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP3
{
    internal class DerivedClass1 : BaseClass
    {
        public override void Message()
        {
            Console.WriteLine("Message from DerivedClass1 (override)");
        }
    }
}
