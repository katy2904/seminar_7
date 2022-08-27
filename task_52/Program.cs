/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetArray(rows, columns);

PrintArray(matrix);

Console.Write("Среднее арифметическое каждого столбца: ");
double result = 0;

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result +=  matrix[j, i];
    }
double average = Math.Round(result / rows, 2);
result = 0;
Console.Write(average + "; ");
}