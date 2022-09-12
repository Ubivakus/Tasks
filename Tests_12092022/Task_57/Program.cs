// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

int[,] FillArray(int row, int colomns)
{
    int[,] array = new int[row, colomns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void CounterBook(int[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);

    for (int checkItem = 0; checkItem < 10; checkItem++)
    {
        int counter = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < colomns; j++)
            {
                int number = array[i, j];
                if (number == checkItem)
                {
                    counter++;
                }
            }
        }
        if (counter != 0) Console.WriteLine($"Элемент {checkItem} находится повторяется {counter} раз");
    }
}


void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            Console.Write("| " + array[i, j] + " |");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк :");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов :");
int colomns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Исходный массив");
int[,] fullArray = FillArray(row, colomns);
PrintArray(fullArray);
CounterBook(fullArray);

