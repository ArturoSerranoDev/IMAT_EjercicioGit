namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Divide(2,8)}");

            Console.WriteLine($"{Substract(2,7)}");
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
                Console.WriteLine("Error, no se puede dividir por 0");
                return 0;
            }
            return x / y; 
        }
        static int Substract(int x, int y)
        {
            return x - y;
        }

    }
}