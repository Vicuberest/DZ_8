// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++) 
    {
     for (int j = 0; j < matrix.GetLength(1); j++) 
        {
           matrix[i,j] = new Random().Next(11); 
           Console.Write(matrix[i,j] + "\t");
        }
            Console.WriteLine();
    }

  int minSumRow = int.MaxValue;
  int indexMinRow = 0;
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
                rowSum += matrix[i, j];
        if (rowSum < minSumRow)
            {
                minSumRow = rowSum;
                indexMinRow = i;
            }
    }
 
Console.WriteLine($"Строка с минимальной суммой элементов: {indexMinRow + 1}"); 
