// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Hello, ex_54!");
Console.WriteLine();
int[,] array = GetArrayRandom(3,4);
PrintArray_1(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();







int[,] GetArrayRandom(int rows, int cols)
{
    int [,] array = new int[rows, cols];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10);
        }
    }
    return array;
}

void PrintArray_1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            Console.Write(array[i, j] + "\t");
         }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array, i);
         for (int j = 0; j < array.GetLength(1); j++)
         {
            Console.Write(array[i, j] + "\t");
         }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void SortRow(int[,] m, int r)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = i + 1; j < m.GetLength(1); j++)
        {
            if (m[r, i] < m[r, j])
            {
                int tmp = m[r, i];
                m[r, i] = m[r, j];
                m[r, j] = tmp;
           }
        }
    }    
       
}
