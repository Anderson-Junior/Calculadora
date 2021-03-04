using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculadora
    {
        public double A, B;
        public double Somar(double a, double b)
        {
            if(a == 0 || b == 0)
            {
                throw new ArgumentException("Digite um valor diferente de zero!!");
            }
            return a + b;
        }
        public double Subtrair(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentException("Digite um valor diferente de zero!!");
            }
            return a - b;
        }
        public double Multiplicar(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentException("Digite um valor diferente de zero!!");
            }
            return a * b;
        }
        public double Dividir(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentException("Digite um valor diferente de zero!!");
            }
            return a / b;
        }
    }
}
