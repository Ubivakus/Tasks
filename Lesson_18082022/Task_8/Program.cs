﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Введите любое натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;
Console.WriteLine("Введённое число N равно " + N + ".");


if (N >= a) {
    Console.Write("Все чётные числа от 1 до " + N + ": ");
    while (a <= N) {
        Console.Write(a + " ");
        a += 2;
    }
} else {
    Console.WriteLine("Введённое вами число " + N + " меньше 2.");
}

Console.WriteLine();
Console.Write("Программа завершена.");

