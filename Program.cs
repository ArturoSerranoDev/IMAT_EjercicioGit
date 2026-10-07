namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string id = "12345678";
            Console.WriteLine(Divide(id[0], id[^1]));
            Console.WriteLine(Subtract(id[0] - '0', id[^1] - '0'));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            if (y == 0) 
            { 
                Console.WriteLine($"Error. Se indicó como numerador {x} y como denominador {y}. División por cero imposible."); 
                return 0; 
            }
            return x / y;
        }
    }
}
