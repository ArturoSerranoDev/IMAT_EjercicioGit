namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 1;
            
            Console.WriteLine($"{Subtract(x,y)}");
            Console.WriteLine($"{Divide(x,y)}");
        }

        static int Add(int x, int y) { return x + y; }
        static int Multiply(int x, int y) { return x * y; }
        static int Subtract(int x, int y){ return x - y; }
        static int Divide(int x, int y) {return x / y; }
    }
}