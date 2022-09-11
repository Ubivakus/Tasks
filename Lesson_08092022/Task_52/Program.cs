/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
System.Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
System.Console.WriteLine();

System.Console.Write("Задайте размер двумерного массива через пробел: ");
string[] sizeOfMatrix = InputFromConsole();
double[,] massive = CreateMatrix(sizeOfMatrix);
AverageSumOfColumn(massive);
System.Console.WriteLine("Программа завершена успешно.\n");


// Функции будут здесь.

string[] InputFromConsole() // Функция принимает данные из консоли и сохраняет в массив.
{
    string input = Console.ReadLine();
    string[] splitArray = input.Split(' ');
    return splitArray;
}


double[,] CreateMatrix(string[] array) // Создаем, заполняем и выводим в консоль двумерный массив размером заданным пользователем.
{
    System.Console.WriteLine();
    int rows = int.Parse(array[0]);
    int columns = int.Parse(array[1]);
    double[,] newArray = new double[rows, columns];
    System.Console.WriteLine("Ваш новый массив: ");

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(10, 100);
            System.Console.Write($"{newArray[i, j]}     ");
        }
        System.Console.WriteLine();
    }
    return newArray;
}


void AverageSumOfColumn(double[,] array)
{
    System.Console.Write("\nСреднее арифметическое каждого столбца: ");

    for (int column = 0; column < array.GetLength(1); column++)
    {
        double averageSum = 0;
        bool isEnd = false;

        for (int row = 0; row < array.GetLength(0); row++)
        {
            averageSum += array[row, column];

            if (row == array.GetLength(0) - 1 & column == array.GetLength(1) - 1)
            {
                isEnd = true;
            }
        }
        if (!isEnd) System.Console.Write($"{string.Format("{0:F2}", averageSum / array.GetLength(0))}; ");
        else System.Console.WriteLine($"{string.Format("{0:F2}", averageSum / array.GetLength(0))}.");
    }
    System.Console.WriteLine();
}

