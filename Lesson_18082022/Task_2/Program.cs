/*
Урок 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Число a равно " + a + ", ");
Console.WriteLine("число b равно " + b + ".");
Console.WriteLine("Сравним эти числа.");
if (a > b) {
    Console.WriteLine("Число a является большим, а число b меньшим.");
} else if (a < b) {
    Console.WriteLine("Число b является большим, а число a меньшим.");
} else {
    Console.WriteLine("Числа a и b равны.");
}
Console.Write("Программа завершена успешно.");