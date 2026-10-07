namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2, 2));
            Console.WriteLine($"Resta: {Subtract(2, 5)}");
        }

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
            {
                Console.WriteLine($"Error: no se puede dividir {x} entre {y}.");
                return 0;
            }
            return x / y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }
    }   

}