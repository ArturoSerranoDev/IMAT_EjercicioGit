namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2, 5));
            Console.WriteLine($"Resta: {Subtract(2, 3)}");
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
            if (y == 0)
            {
                Console.WriteLine($"Error: no se puede dividir entre {x} entre {y}");
                return 0;
            }

            return x / y;
        }

        static int Subtract(int x, int y)
        {
            x - y
        }
    }
}