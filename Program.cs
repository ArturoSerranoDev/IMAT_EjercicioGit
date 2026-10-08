namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Resta: {Subtract(2, 6)}");
            Console.WriteLine($"División: {Divide(2, 9)}");
        }

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
                Console.WriteLine($"Error: no se puede dividir {x} entre {y}");
                return 0;
            }
            return x / y;
        }
    }
}