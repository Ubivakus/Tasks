// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();

System.Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.\n");
int sequence = SequenceOfNumbers(1, 10);


// Функция будет здесь.

int SequenceOfNumbers(int firstNumber, int secondNumber)
{
    Console.Write(firstNumber + ", ");
    if (firstNumber == secondNumber)
    {
        return firstNumber;
    }
    else
    {
        return firstNumber + SequenceOfNumbers(firstNumber + 1, secondNumber);
    }
}


