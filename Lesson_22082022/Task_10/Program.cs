/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
System.Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
System.Console.Write("Введите целое трёхзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = number % 100 / 10;

System.Console.WriteLine($"Вторая цифра вашего числа: {secondDigit}");