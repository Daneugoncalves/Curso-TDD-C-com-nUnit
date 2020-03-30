using System;

namespace Asserts
{
    public class Calculadora
    {
        public int SomarNumerosInteiros(int num1, int num2)
        {
            return num1 + num2;
        }

        public double SomarNumerosDecimais(double num1, double num2)
        {
            return num1 + num2;
        }

        public int Dividir(int num1, int num2)
        {
            if (num1 > 100)
            {
                throw new ArgumentOutOfRangeException("num2");
            }

            return num1/num2;
        }
    }
}
