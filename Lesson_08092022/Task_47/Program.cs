/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.Clear();
System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.\n");

int m = 3, n = 4;
int[,] myArray = CreateArray(m, n);

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
            System.Console.Write($"{array[i, j]}    ");
        }
        System.Console.WriteLine();
    }
    return array;
}