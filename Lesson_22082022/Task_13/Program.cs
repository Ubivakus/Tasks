/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear();
int number; 
int orderOfDigit = 2;

System.Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
System.Console.Write("Введите любое целое число: ");
number = Convert.ToInt32(Console.ReadLine());
string stringOfNumber = number.ToString();
System.Console.WriteLine($"Ваше число: {stringOfNumber}");

if (stringOfNumber.Length > orderOfDigit)
{
    System.Console.WriteLine($"Третья цифра вашего числа - {stringOfNumber[orderOfDigit]}");
} else
{
    System.Console.WriteLine("В вашем числе нет третьей цифры! Попробуйте другое число");
}
System.Console.WriteLine("Программа завершена.");



