// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ex_54!");

double[,] array = GetArrayRandom(3,4);
PrintArray(array);

double[,] GetArrayRandom(int rows, int cols)
{
    double [,] array = new double[rows, cols];
    Random random = new Random();
    double minRandom = -10;
    double maxRandom = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //array[i, j] = random.Next(10);
            array[i, j] = random.NextDouble() * (maxRandom - minRandom) + minRandom; 
        }
    }
    return array;
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
              Console.Write(Math.Round( array[i, j], 1) + "\t");
         }
        Console.WriteLine();
    }
}

