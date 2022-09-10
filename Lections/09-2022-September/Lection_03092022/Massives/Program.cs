//Двумерные массивы и рекурсия

Console.Clear();

/*
string[,] table = new string[2, 5]; //Массив строк
table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/


//Принимает на вход готовый пустой массив и распечатывает его поэлементно в виде матрицы
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

//Теперь опишем дополнительный метод, который будет заполнять нашу матрицу случайными числами.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-99, 100);
        }
    }
}

int[,] matrix = new int[3, 4]; //Матрица из чисел
PrintArray(matrix); //Распечатали пустую матрицу
FillArray(matrix); //Заполнили случайными числами матрицу
System.Console.WriteLine();
PrintArray(matrix);
