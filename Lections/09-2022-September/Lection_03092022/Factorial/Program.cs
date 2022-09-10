Console.Clear();
for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i} = {Factorial(i)}");
}

//Рекурсия функции нахождения факториала
double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}