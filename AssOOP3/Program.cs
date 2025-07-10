using System;

namespace AssOOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add(5, 10));
            Console.WriteLine(cal.Add(1,2,3));
            Console.WriteLine(cal.Add(2.5,3.8));
            #endregion
        }
    }
}
