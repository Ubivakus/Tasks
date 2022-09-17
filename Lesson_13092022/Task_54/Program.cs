// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
System.Console.WriteLine("Задача 54: Задайте двумерный массив."
                        + "Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n");
System.Console.Write("Задайте размер двумерного массива через пробел: ");
string[] sizeOfMatrix = InputFromConsole();
int[,] massive = CreateMatrix(sizeOfMatrix);
int[,] sortedMassive = SortRowsByIncreacing(massive);
PrintArray(sortedMassive);

System.Console.WriteLine("\nПрограмма завершена успешно.\n");


// Функции будут здесь.

string[] InputFromConsole() // Функция принимает данные из консоли и сохраняет в массив.
{
    string input = Console.ReadLine();
    string[] splitArray = input.Split(' ');
    return splitArray;
}


int[,] CreateMatrix(string[] array) // Создаем, заполняем и выводим в консоль двумерный массив размером заданным пользователем.
{
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

void PrintArray(int[,] array) // Печать массива
{
    System.Console.WriteLine("\nОтсортированный массив:");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}    ");
        }
        System.Console.WriteLine();
    }
}

int[,] SortRowsByIncreacing(int[,] array) // Сортировка строки в массиве с помощью функций Sort и Reverse
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    int[] tempArray = new int[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[j] = array[i, j];

        }
        Array.Sort(tempArray);
        Array.Reverse(tempArray);

        for (int m = 0; m < array.GetLength(1); m++)
        {
            newArray[i, m] = tempArray[m];
        }
    }
    return newArray;
}



