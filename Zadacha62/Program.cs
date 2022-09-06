// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int sizeRows = 5;
int sizeColumns = 5;
int[,] spiralMatrix = new int[sizeRows, sizeColumns];
int row = 0;
int column = 0;
int dx = 1;//Величина начального шага по горизонтали
int dy = 0;//Величина начального шага по вертикали
//dx=1, dy=0 - начинаем шагать вправо от [row, column]
//dx=1, dy=0 - начинаем шагать вниз от [row, column]

int dirChanges = 0;//Количество разворотов заполнения по матрице
int gran = sizeColumns;//Количество шагов до разворота

for (int i = 0; i < spiralMatrix.Length; i++)
{
    spiralMatrix[row, column] = i + 1;
    gran--;
    if (gran == 0)//Пришло время развернуться
    {
        gran = sizeColumns*(dirChanges%2) + sizeRows*((dirChanges + 1)%2) - (dirChanges/2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    column += dx;
    row += dy;
}
for (int i = 0; i < spiralMatrix.GetLength(0); i++) 
{
    for (int j = 0; j < spiralMatrix.GetLength(1); j++) 
    {
        Console.Write(spiralMatrix[i,j] + "\t");
    }
    Console.WriteLine();
}
