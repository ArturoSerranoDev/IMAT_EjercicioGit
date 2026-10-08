namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Divide(2,1));

            Console.WriteLine(Subtract(2,5));
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int x, int y)
        {
            return x*y;
        }


        static int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Error: división por 0", y, x);
                return 0;
            }
            else
            {
                return x/y;
            }
        }


        static int Subtract(int x, int y)
        {
            return x-y;
        }

    }
}