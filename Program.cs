namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2, 8));

            Console.WriteLine(Subtract(2, 0));

        }


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            if (y == 0)
            {   

                Console.WriteLine("No se puede dividir entre cero, denominador(y) = 0)
            }
            return x / y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }

}
