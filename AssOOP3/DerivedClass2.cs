using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP3
{
    public class DerivedClass2 : BaseClass
    {
        public new void Message() {
            Console.WriteLine("Message from DerivedClass2 (new)");
        }
    }
}
