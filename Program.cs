namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"la división de mi primer y ultimo digito es ID : {Divide(2, 9)}");
        }

        static int Add(int x, int y)
        {
        
            return x + y;
        }

        static int Multiply(int x, int y)
        {   
            return x * y;   
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Divide(int x, int y)
        {
            if (y == 0)
                {
                    throw new DivideByZeroException($"No se puede dividir por cero. Los valores son: {x} y {y}");
                }
            return x / y;

        }
    }
}