namespace IMAT_GitTest
{
    internal class Program
    {
        public static int Add(int x, int y)
            {
                return x + y;
            }

        public static int Multiply(int x, int y)
            {
                return x * y;
            }


        public static int Subtract(int x, int y)
        {
            return x - y;
        }
      
      
        public static double Divide(int x, int y)
            {
                if (y == 0)
            {
                Console.WriteLine($"No se puede dividir {x} entre {y}.");
                return 0;
            }
            return x / y;
        }

        
      static void Main(string[] args)
        {
            string ID_Javier = "202407851";
            string ID_Pedro = "202306656";

            int primero_Ja = ID_Javier[0] - '0';
            int ultimo_Ja = ID_Javier[8] - '0';
        
            int primero_Pe = ID_Pedro[0] - '0';
            int ultimo_Pe = ID_Pedro[8] - '0';

            Console.WriteLine($"La resta del primer y último término del ID de Javier es: {Subtract(primero_Ja, ultimo_Ja)}");
            Console.WriteLine($"La división del primer y último término del ID de Pedro es: {Divide(primero_Pe, ultimo_Pe)}");
        }
    }
}
