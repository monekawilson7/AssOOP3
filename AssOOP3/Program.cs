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

            #region Q2
            Rectangle rec1 = new Rectangle();
            Rectangle rec2 = new Rectangle(5,10);
            Rectangle rec3 = new Rectangle(7);

            Console.WriteLine(rec1.ToString());
            Console.WriteLine(rec2.ToString());
            Console.WriteLine(rec3.ToString());
            #endregion

            #region Q3
            ComplexNumber c1 = new ComplexNumber(3,4);
            ComplexNumber c2 = new ComplexNumber(10,15);

            ComplexNumber plus = c1 + c2;
            ComplexNumber minus = c1 + c2;
            Console.WriteLine(plus);
            Console.WriteLine(minus);
            #endregion
        }
    }
}
