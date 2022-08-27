/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/


int[,] array = new int[5, 5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
    }
}

void PrintArray(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            Console.Write(matrix[k, m] + "\t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите ряд: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

PrintArray(array);

if (row > array.GetLength(0) || column > array.GetLength(1)) Console.WriteLine("Такого числа в массиве нет");
else Console.WriteLine($"Это число {array[row, column]}");