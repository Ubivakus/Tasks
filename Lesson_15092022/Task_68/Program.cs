// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


Console.Clear();
System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.\nДаны два неотрицательных числа m и n.");

int m = 2;
int n = 8;
Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AkkermanFunction(m, n)}");

// Функция будет здесь.

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}