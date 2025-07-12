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

            #region Q4
            Employee emp = new Employee();
            emp.Work();
            Manager manager = new Manager();
            manager.Work();
            #endregion

            #region Q5
            BaseClass baseClass = new BaseClass();
            baseClass.Message();
            BaseClass drived = new DerivedClass1();
            drived.Message();
            BaseClass drived2 = new DerivedClass2();
            drived2.Message();
            DerivedClass2 obj = new DerivedClass2();
            obj.Message();
            #endregion

            #region part2
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());
            Duration D4 = new Duration(3600);
            Console.WriteLine(D4.ToString());
            D3 = D1 + D2;
            Console.WriteLine(D3);
            D3 = D1 +7800;
            Console.WriteLine(D3);
            D3 = 666 + D3;
            Console.WriteLine(D3);
            D3 = ++D1;
            Console.WriteLine(D3);
            D3 = --D2;
            Console.WriteLine(D3);
            D1 = D1 - D2;
            Console.WriteLine(D1);
            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");
            else
                Console.WriteLine("D1 is NOT greater than D2");

            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal to D2");
            else
                Console.WriteLine("D1 is NOT less than or equal to D2");


            if (D1)
                Console.WriteLine("D1 has positive duration");
            else
                Console.WriteLine("D1 has zero or negative duration");

            DateTime dt = (DateTime)D3;
            #endregion

        }
    }
}
