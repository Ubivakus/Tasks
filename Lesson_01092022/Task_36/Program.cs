/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] FillAndPrintArray() //Создает, заполняет, выводит в консоль и сохраняет массив
{
    System.Console.Write("Задайте размер массива: ");
    int size = Int32.Parse(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10);
    }
    for (int j = 0; j < size; j++)
    {
        if (j == 0) System.Console.Write($"[{array[j]}, ");
        else if (j < size - 1) System.Console.Write($"{array[j]}, ");
        else System.Console.Write($"{array[j]}]");
    }
    System.Console.WriteLine();
    return array;
}

void SumOfOddElements(int[] array) //Ищет и складывает значения элементов на нечётных позициях (индексах)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}.");
}

Console.Clear();
int[] newArray = FillAndPrintArray();
SumOfOddElements(newArray);

