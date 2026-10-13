namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id = "202410237";
            int id0 = id[0] - '0'; // Convert the first character to an integer
            int idLast = id[id.Length - 1] - '0'; // Convert the last character to an integer

            Console.WriteLine(Subtract(id0, idLast));
            Console.WriteLine(Divide(id0, idLast));
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
                Console.WriteLine("Error: no se puede dividir entre 0.");
                return 0;
            }
            return x / y;
        }
    }
}