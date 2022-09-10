//Фибоначчи
Console.Clear();

for (int i = 1; i < 100; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
