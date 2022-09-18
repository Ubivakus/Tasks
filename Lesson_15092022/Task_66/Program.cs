// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n");

int sum = 0;
System.Console.WriteLine(SumOfNumbers(4, 8));


// Функция будет здесь.

int SumOfNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber) return sum;
    else return sum += firstNumber + SumOfNumbers(firstNumber + 1, secondNumber);
}