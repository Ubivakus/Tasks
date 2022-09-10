/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Clear();

// Общение с пользователем.
System.Console.Write("Задайте размер матрицы через пробел: ");
string[] sizeOfMatrix = InputFromConsole(); // Вызываем функцию, считывающую два значения и получаем массив с размером будущего массива.
int[,] matrix = CreateMatrix(sizeOfMatrix); // Вызываем функцию и получаем массив, с которым будем работать.
CheckElement(matrix);
System.Console.WriteLine("Программа завершена успешно.");
System.Console.WriteLine();

// Функции будут здесь.

string[] InputFromConsole() // Функция принимает данные из консоли и сохраняет в массив.
{
    string input = Console.ReadLine();
    string[] splitArray = input.Split(' ');
    return splitArray;
}

int[,] CreateMatrix(string[] array) // Создаем, заполняем и выводим в консоль двумерный массив размером заданным пользователем.
{
    System.Console.WriteLine();
    int rows = int.Parse(array[0]);
    int columns = int.Parse(array[1]);
    int[,] newArray = new int[rows, columns];
    System.Console.WriteLine("Матрица создана: ");

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

void CheckElement(int[,] matrix) // Функция проверяет элемент на причастность его к массиву и выводит в консоль. Машины считают с 0, а люди с 1.
{
    while (true)
    {
        System.Console.WriteLine();
        System.Console.Write("Введите строку и столбец желаемого элемента через пробел или 0 0 для завершения программы: ");
        string[] indexes = InputFromConsole();
        int row = int.Parse(indexes[0]);
        int column = int.Parse(indexes[1]);

        if (row < 0
        | row > matrix.GetLength(0)
        | column < 0
        | column > matrix.GetLength(1)) System.Console.WriteLine("Элемента с таким индексом в матрице не существует!");
        else if (row == 0 & column == 0) break;
        else System.Console.WriteLine($"Элемент в {row} строке {column} столбца равен {matrix[row - 1, column - 1]}.");
    }
}