// Задайте двумерный массив.
//  Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 

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

// Сортировка пузырьком
    for (int i = 0; i < matrix.GetLength(0); i++)//Перебираем строки
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)//Делаем j замен
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)//Проходим по всемлементам строки
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int tempElement = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = tempElement;
                }
            }
        }
    }

Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++) 
    {
     for (int j = 0; j < matrix.GetLength(1); j++) 
        {
           Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
