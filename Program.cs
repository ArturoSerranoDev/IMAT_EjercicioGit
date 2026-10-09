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


        static int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine($"Error: no se puede dividir entre 0 {x}");
                return 0;
            }
            return x / y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;

        }

        static void Main(string[] args)
        {

            Console.WriteLine($"División: 2 / 4 = {Divide(2, 4)}");

            Console.WriteLine($"Resta: 2 - 2 = {Subtract(2, 2)}");
        }
    }
}
