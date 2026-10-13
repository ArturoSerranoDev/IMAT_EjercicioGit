namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Subtract(2,8)}");
        }

        static int Add(int x, int y) {return x + y;} 
        static int Subtract(int x, int y) 
        {
            if (y == 0)
            { return -1; }
            return x - y;}
    }
}