namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"División: {Divide(2, 2)}");
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
            return x / y;
        }
    }
}