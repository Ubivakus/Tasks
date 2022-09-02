/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.Clear();

while (true)
{
    System.Console.Write("Введите любое натуральное число или '0' для выхода из программы: ");
    string number = Console.ReadLine();
    if (number.Equals("0")) break;
    int sumOfDigits = 0;    

    for (int i = 0; i < number.Length; i++)
    {
        sumOfDigits += int.Parse(number[i].ToString());
    }
    System.Console.WriteLine($"Сумма цифр вашего числа равна {sumOfDigits}.");
}

System.Console.WriteLine("Программа завершена.");




