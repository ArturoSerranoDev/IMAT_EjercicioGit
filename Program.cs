namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine(Multiply(2,5));
        }

        private int Add(int x, int y){
            return x+y;
        }
        private int Multiply(int x, int y){
            return x*y;
        }


    }
}