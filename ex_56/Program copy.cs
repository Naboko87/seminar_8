// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Hello, ex_56!");
Console.WriteLine();
int[,] array = GetArrayRandom(2,2);
PrintArray_1(array);
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
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


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
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
    for (int i = 1; i < array.GetLength(0); i++)
    {   
            int tempSumLine = SumLineElements(array, i);
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
        
    }
    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой элементов ");
}



