/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
System.Console.WriteLine("Задача 23. \nНапишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
System.Console.Write("Введите любое натуральное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Таблица кубов чисел от 1 до вашего числа {userNumber}: ");
countCubeAndPrint(userNumber);
System.Console.WriteLine("Программа завершена.");

//Функция будет здесь
void countCubeAndPrint(int x) //Считает куб чисел в цикле и выводит их на экран в красивом оформлении
{    
    int digit = 1;
    int pow = 3;
    Console.Write(digit = Convert.ToInt32(Math.Pow(digit, pow)));

    for(int i = 1; i < x; i++)    
    {
        Console.Write($", {digit = Convert.ToInt32(Math.Pow(i + 1, pow))}");
    }
    System.Console.WriteLine(".");  
}