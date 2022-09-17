// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
System.Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
System.Console.WriteLine("\nСоздадим первую матрицу.");
int[,] matrix1 = CreateMatrix();
System.Console.WriteLine("\nСоздадим вторую матрицу.");
int[,] matrix2 = CreateMatrix();
System.Console.WriteLine("\nВыполним операцию произведения двух матриц.");
MultiplyMatrix(matrix1, matrix2);
System.Console.WriteLine("\nПрограмма завершена успешно.\n");


// Функции будут здесь.

int[,] CreateMatrix() // Создаем, заполняем и выводим в консоль двумерный массив размером заданным пользователем через консоль.
{
    System.Console.Write("\nЗадайте размер матрицы через пробел: ");
    string input = Console.ReadLine();
    string[] array = input.Split(' ');
    int rows = int.Parse(array[0]);
    int columns = int.Parse(array[1]);
    int[,] newArray = new int[rows, columns];
    FillArray(newArray);
    PrintArray(newArray);
    return newArray;
}


void MultiplyMatrix(int[,] arr1, int[,] arr2) // Произведение двух матриц.
{
    int newElement = 0;
    int[,] newMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];

    if (matrix1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < arr2.GetLength(1); i++)
        {
            for (int j = 0; j < arr1.GetLength(0); j++)
            {
                newElement = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    newElement += arr1[j, k] * arr2[k, i];
                    newMatrix[j, i] = newElement;
                }
            }
        }

        System.Console.WriteLine("\nРезультат произведения двух матриц равен:");
        PrintArray(newMatrix);
    }
    else Console.WriteLine("\nВнимание! Ошибка! Такие матрицы не могут быть умножены!"
                            + "Задайте допустимые размеры матриц.");
}


int[,] FillArray(int[,] array) // Заполенние массива рандомными числами.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array) // Печать массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}    ");
        }
        System.Console.WriteLine();
    }
}