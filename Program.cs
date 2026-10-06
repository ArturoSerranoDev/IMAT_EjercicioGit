using System.ComponentModel;

namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(2, 8);
            Console.WriteLine($"El resultado de la suma del primer y ultimo digito es: {result}");
        }

        static int Add(int x, int y) { return x + y; }
    }
}