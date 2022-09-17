// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

System.Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.\n\n"
                        + "Например, на выходе получается вот такой массив:\n");

int[,] massive = FillSpiralMassive(4, 4);
PrintArray(massive);


// Функции будут здесь.

int[,] FillSpiralMassive(int row, int col)
{
    int[,] array = new int[row, col];
    int number = row * col;
    int element = 1;
    int i = 0, j = 0;
    while (element <= number)
    {
        array[i, j] = element++;
        if (i <= j + 1 && i + j < col - 1)
            j++;
        else if (i < j && i + j >= row - 1)
            i++;
        else if (i >= j && i + j > col - 1)
            j--;
        else
            i--;
    }
    return array;
}


void PrintArray(int[,] array) // Печать массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}     ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}