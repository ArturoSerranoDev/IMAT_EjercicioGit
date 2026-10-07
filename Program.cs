namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2,9));
            
            Console.WriteLine(Subtract(2, 7));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x*y;
            }
        static int Divide(int x, int y)
        {
            if (y==0)
            {
                Console.WriteLine($"Error , valores: {x} e {y}"); 
                return 0; 
                }
            else 
            {
                return x / y;
            }
        }
        static int Subtract(int x, int y)
        {
            return x-y;
         }
    }
}
