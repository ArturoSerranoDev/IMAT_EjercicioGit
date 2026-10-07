namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Divide(2, 8);
            Console.WriteLine($"The division of 2 and 8 is {result}");
            int result1 = Subtract(2, 0);
            Console.WriteLine($"The subtraction of 2 and 0 is {result1}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int? Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine($"Division entre {x} y {y} no es valido");
                return null;
            }
            return x / y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}