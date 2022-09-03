/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

void FillArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    int size = array.Length;
    System.Console.Write("Ваш массив: ");
    for (int i = 0; i < size; i++)
    {
        if (i == 0) System.Console.Write($"[{array[i]}, ");
        else if (i < size - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}]");
    }
    System.Console.WriteLine();
}

void CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) count++;
    }
    System.Console.WriteLine($"Количество чётных чисел в массиве: {count}.");
}

Console.Clear();
System.Console.Write("Задайте длину массива: ");
int size = Int32.Parse(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
CountEvenNumbers(array);