// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк для первой матрицы: ");
int firstRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для первой матрицы: ");
int firstColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк для второй матрицы: ");
int secondRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для второй матрицы: ");
int secondColumns = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[firstRows, firstColumns];

for (int i = 0; i < firstMatrix.GetLength(0); i++) 
    {
     for (int j = 0; j < firstMatrix.GetLength(1); j++) 
        {
           firstMatrix[i,j] = new Random().Next(11); 
           Console.Write(firstMatrix[i,j] + "\t");
        }
            Console.WriteLine();
    }

    Console.WriteLine();

    int[,] secondMatrix = new int[secondRows, secondColumns];

for (int i = 0; i < secondMatrix.GetLength(0); i++) 
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++) 
    {
        secondMatrix[i,j] = new Random().Next(11); 
        Console.Write(secondMatrix[i,j] + "\t");
    }
    Console.WriteLine();
}
    Console.WriteLine();

int[,] resultMatrix = new int[firstRows,secondColumns];

if (firstColumns != secondRows)
{
    Console.Write("Умножать матрицы нельзя!");  
    return;
}

for (int i = 0; i < firstRows; i++)
{
    for (int j = 0; j < secondColumns; j++)
    {
        int sum = 0;
        for (int k = 0; k < firstColumns; k++)
        {
            sum += firstMatrix[i,k] * secondMatrix [k,j];
        }

        resultMatrix[i,j] = sum;
    }
}   

Console.WriteLine("Результат:");
for (int i = 0; i < resultMatrix.GetLength(0); i++) 
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++) 
    {
        Console.Write(resultMatrix[i,j] + "\t");
    }
    Console.WriteLine();
}
