/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] SetArray(int size) //Функция принимает на вход размер массива и возвращает заполненный массив случайными числами
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

void PrintArray(int[] array) //Выводит массив в консоль
{
    System.Console.Write("Ваш массив: ");
    foreach(int item in array)
    {
        System.Console.Write("\t{0}", item);
    }
    System.Console.WriteLine();
}

Console.Clear();

System.Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = SetArray(size);
PrintArray(array);


