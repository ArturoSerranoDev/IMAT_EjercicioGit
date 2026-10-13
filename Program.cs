namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 0;
            
            Console.WriteLine($"{Subtract(x,y)}");
            Console.WriteLine($"{Divide(x,y)}");
        }

        static int Add(int x, int y) { return x + y; }
        static int Multiply(int x, int y) { return x * y; }
        static int Subtract(int x, int y){ return x - y; }
        static double Divide(int x, int y) 
        {
            if (y == 0) 
            {
                Console.WriteLine($"Cannot divide by 0, inputs: {x}, {y}. ");
                return 0.0;
             }
            else {return x / y; } 
        }
    }
}