namespace IMAT_GitTest
{
    internal class Program
    {

        int result = Multiply(2, 7);
        Console.WriteLine($"{result}");


        static int Add(int x, int y)
        {
            return x + y
        }

        static int Multiply(int x, int y) 
        { 
            return (int)(x * y);
        }
        
    }
}