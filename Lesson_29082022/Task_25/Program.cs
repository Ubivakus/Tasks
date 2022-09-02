/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Clear();

while (true)
{
    System.Console.Write("Введите два натуральных числа через пробел, или '0' для завершения программы: ");
    string line = Console.ReadLine();
    if (line.Equals("0")) break;
    string[] numbers = line.Split(' ');
    int a = Convert.ToInt32(numbers[0]);
    int b = Convert.ToInt32(numbers[1]);
    double x = Math.Pow(a, b);
    System.Console.WriteLine(x);    
}

System.Console.WriteLine("Программа завершена.");