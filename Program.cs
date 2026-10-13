namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Divide(2,2));
            Console.WriteLine(Subtract(2,4));

        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine($"ERROR: division por 0. Input x: {x}, y:{y}");
                return 0;
            }
            return x / y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}