namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(0, 9));
            Console.WriteLine(Subtract(5, 3));
        }

        static public int Add(int x, int y) { return x + y; }
        static public int Multiply(int x, int y) { return x * y; }
        static public int Divide(int x, int y) {
            if (y==0)
            {
                Console.WriteLine("Error: division by zero.");
                return 0;
            }
            return x / y;
        }
        static public int Subtract(int x, int y) { return x - y; }
    }
}