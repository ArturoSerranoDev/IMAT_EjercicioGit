namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Divide(2, 8)}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        { 
            return (a * b);
        }

        static double? Divide(int a, int b)
        {
            if (b == 0) { return $"Error division por cero. Valores {a}/{b}"}
            return a / b;
        }
    }