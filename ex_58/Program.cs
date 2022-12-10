// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ex 58!");
Console.WriteLine();
Console.WriteLine("Hello, ex_54!");
Console.WriteLine();
int[,] array_A= Array_A(2,2);
PrintArray_A(array_A);
Console.WriteLine();
int[,] array_B= Array_B(2,2);
PrintArray_B(array_B);
Console.WriteLine();
int[,] array_C= Array_C(2,2);
PrintArray_C(array_C);
Console.WriteLine();


int[,] Array_A(int rows, int cols)
{
    int [,] array_A = new int[rows, cols];
    Random random = new Random();

    for (int i = 0; i < array_A.GetLength(0); i++)
    {
        for (int j = 0; j < array_A.GetLength(1); j++)
        {
            array_A[i, j] = random.Next(10);
        }
    }
    return array_A;
}
int[,] Array_B(int rows, int cols)
{
    int [,] array_B = new int[rows, cols];
    Random random = new Random();

    for (int i = 0; i < array_B.GetLength(0); i++)
    {
        for (int j = 0; j < array_B.GetLength(1); j++)
        {
            array_B[i, j] = random.Next(10);
        }
    }
    return array_B;
}

int[,] Array_C(int rows, int cols)
{
    int k;
    int [,] array_C = new int[rows, cols];


    for (int i = 0; i < array_A.GetLength(0); i++)
    {
        for (int j = 0; j < array_B.GetLength(1); j++)
        {
            for(k=0; k < array_C.GetLength(1); k++)
            {
            array_C[i, j] += array_A[i, k] * array_B[k, j];
            }
        }
    }
    return array_C;
}



void PrintArray_A(int[,] array_A)
{
    for (int i = 0; i < array_A.GetLength(0); i++)
    {
         for (int j = 0; j < array_A.GetLength(1); j++)
         {
            Console.Write(array_A[i, j] + "\t");
         }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray_B(int[,] array_B)
{
    for (int i = 0; i < array_B.GetLength(0); i++)
    {
         for (int j = 0; j < array_B.GetLength(1); j++)
         {
            Console.Write(array_B[i, j] + "\t");
         }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray_C(int[,] array_C)
{
    for (int i = 0; i < array_C.GetLength(0); i++)
    {
         for (int j = 0; j < array_C.GetLength(1); j++)
         {
            Console.Write(array_C[i, j] + "\t");
         }
        Console.WriteLine();
    }
    Console.WriteLine();
}



