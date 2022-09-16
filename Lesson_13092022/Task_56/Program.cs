// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
System.Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
int[,] massive = CreateMatrix();
CompariseSumOfElementsOfRow(massive);

System.Console.WriteLine("\nПрограмма завершена успешно.\n");


// Функции будут здесь.

int[,] CreateMatrix() // Создаем, заполняем и выводим в консоль двумерный массив размером заданным пользователем через консоль.
{
    System.Console.Write("\nЗадайте размер двумерного массива через пробел: ");
    string input = Console.ReadLine();
    string[] array = input.Split(' ');
    int rows = int.Parse(array[0]);
    int columns = int.Parse(array[1]);
    int[,] newArray = new int[rows, columns];
    System.Console.WriteLine("\nВаш массив: ");

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


void CompariseSumOfElementsOfRow(int[,] array) // Функция принимает массив, считает сумму элементов строк, находит минимальную, и выводит в консоль её номер (по-человечески).
{
    int sum = 0, minSum = 0, minRow = 0;
    int[] arrayOfSums = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        arrayOfSums[i] = sum;
    }
    minSum = arrayOfSums.Min();
    minRow = Array.IndexOf(arrayOfSums, minSum) + 1;
    System.Console.WriteLine($"\nСтрока с наименьшей суммой ({minSum}) значений элементов номер ({minRow}).");
}


