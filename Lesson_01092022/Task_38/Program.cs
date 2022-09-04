/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] FillAndPrintArray() //Создает и заполняет случайными числами, выводит в консоль и сохраняет массив 
{
    System.Console.Write("Задайте размер массива: ");
    int size = Int32.Parse(Console.ReadLine());
    double[] array = new double[size];
    System.Console.Write("Ваш массив:   ");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 1000;
        System.Console.Write("{0,6:F2}   ", array[i]);
    }
    System.Console.WriteLine();
    return array;
}

//Найти минимальный и максимальный элементы массива, и разницу между ними
void FindDiffBetweenMinMax(double[] array)
{
    double min = array[0], max = array[0], diff;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }

    System.Console.WriteLine("Минимальное значение в массиве:" + " {0,6:F2}", min);
    System.Console.WriteLine("Максимальное значение в массиве:" + " {0,6:F2}", max);
    System.Console.WriteLine("Разница между минимальным и максимальным значениями: " + "{0,6:F2}", diff = Math.Abs(max - min));
}

Console.Clear();
double[] newArray = FillAndPrintArray();
FindDiffBetweenMinMax(newArray);




