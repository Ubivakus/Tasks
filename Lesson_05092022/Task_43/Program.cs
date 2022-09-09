/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
System.Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, \r\n" +
                         "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;\r\nзначения b1, k1, b2 и k2 задаются пользователем.");

double k1, b1, k2, b2;
Read();
double[] point = FindPoint();
Print(point);

//Метод для общения с пользователем через консоль
void Read()
{
    System.Console.Write("Введите значение k1: ");
    k1 = double.Parse(Console.ReadLine());
    System.Console.Write("Введите значение b1: ");
    b1 = double.Parse(Console.ReadLine());
    System.Console.Write("Введите значение k2: ");
    k2 = double.Parse(Console.ReadLine());
    System.Console.Write("Введите значение b2: ");
    b2 = double.Parse(Console.ReadLine());
}

double[] FindPoint()
{
    double[] point = new double[2]; //Создаем массив
    //Вычисляем x и y
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    point[0] = x; //Присваиваем их значения элементам массива
    point[1] = y;
    return point;
}

void Print(double[] array)
{
    if (k1 == k2) System.Console.WriteLine("Пересечений нет!");
    else Console.WriteLine($"Точка пересечения с координатами x = {point[0]}, y = {point[1]}"); /*Выводим точку перечесения*/
}