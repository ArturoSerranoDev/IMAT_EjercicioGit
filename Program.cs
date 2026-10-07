namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(3,9));
            Console.WriteLine(Subtract(3,9));
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("No se puede divir entre 0");
                return 0;
            }
            
            return x / y;
                
            }
        static int Subtract(int x, int y)
        {
                return x-y;    
        }    
    }
     
}
