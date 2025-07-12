using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP3
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public ComplexNumber(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2) {
            return new ComplexNumber(
                c1.Real - c2.Real,
                c1.Imag - c2.Imag
                );
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(
                c1.Real + c2.Real,
                c1.Imag + c2.Imag
                );
        }
    }
   

}
