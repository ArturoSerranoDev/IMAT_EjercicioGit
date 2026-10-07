namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Restar el primer y último dígito del ID: {Subtract(2, 7)}");
            Console.WriteLine($"División del primer y último dígito del ID: {Divide(2, 7)}");
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
                Console.WriteLine($"Error: División por cero no permitida. Los valores introducidos son {x} y {y}");
            }
            return x / y;
        }
    }
}