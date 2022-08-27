/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Clear();
System.Console.WriteLine("Задача 19. \nНапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

int lengthOfnumber = 5;
string number5Digits;

while (true)
{
    Start();

    if (number5Digits.ToLower() == "end")
        break;

    else if (number5Digits.Length != lengthOfnumber)
        System.Console.WriteLine("Вы ввели не пятизначное число! Попробуйте снова.");

    else if (number5Digits[lengthOfnumber - lengthOfnumber] == number5Digits[lengthOfnumber - 1] &&
    number5Digits[lengthOfnumber - lengthOfnumber + 1] == number5Digits[lengthOfnumber - 2])
        System.Console.WriteLine($"Ваше число {number5Digits} является палиндромом.");

    else
        System.Console.WriteLine($"Ваше число {number5Digits} не является палиндромом.");
}

System.Console.WriteLine("Программа завершена.");

//Функция будет здесь.
void Start()
{
    System.Console.Write("Введите целое пятизначное число: ");
    number5Digits = Console.ReadLine();
}
