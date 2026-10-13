
using System;

namespace IMAT_GitTest
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("No se puede dividir entre cero.");
                return 0;
            }

            return x / y;
        }

        static void Main(string[] args)
        {
            int primerDigito = 2;
            int ultimoDigito = 3;

            Console.WriteLine(
                $"Suma: {Add(primerDigito, ultimoDigito)}"
            );

            Console.WriteLine(
                $"Multiplicación: {Multiply(primerDigito, ultimoDigito)}"
            );

            Console.WriteLine(
                $"Resta: {Subtract(primerDigito, ultimoDigito)}"
            );

            Console.WriteLine(
                $"División: {Divide(primerDigito, ultimoDigito)}"
            );
        }
    }
}

