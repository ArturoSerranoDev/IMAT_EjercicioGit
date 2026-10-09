namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID = 202305400;
            string idTexto = ID.ToString();

            int primero = int.Parse(idTexto[0].ToString());
            int penultimo = int.Parse(idTexto[idTexto.Length - 2].ToString());
            if (penultimo == 0) {
                Console.WriteLine("Error. División por cero. Numerador: " + primero + " Denominador: " + penultimo);

            }
            else { 

                Console.WriteLine("La división del primer y penúltimo dígito del ID " + ID + " es: "+ Divide(primero, penultimo));
            }
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }


        static int Divide(int x, int y)
        {
            return x / y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;

        }
    }
}