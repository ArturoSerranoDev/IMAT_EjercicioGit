static int Divide(int x, int y)
{
    if (y == 0)
    {
        Console.WriteLine("Error: no se puede dividir entre cero.");
        return 0;
    }
 
    return x / y;
}