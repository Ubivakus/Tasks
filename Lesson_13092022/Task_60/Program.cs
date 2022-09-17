// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

System.Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел."
                        + "\r\n           Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.\n");

int[,,] newMassive = new int[2, 2, 2];

FillArray(newMassive);

PrintArray(newMassive);

System.Console.WriteLine();


// Функции будут здесь.

void FillArray(int[,,] array) // Заполенние 3D массива неповторяющимися рандомными числами.
{
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;

    for (int x = 0; x < tempArray.GetLength(0); x++)
    {
        tempArray[x] = new Random().Next(10, 100);
        number = tempArray[x];
        if (x >= 1)
        {
            for (int y = 0; y < x; y++)
            {
                while (tempArray[x] == tempArray[y])
                {
                    tempArray[x] = new Random().Next(10, 100);
                    y = 0;
                    number = tempArray[x];
                }
                number = tempArray[x];
            }
        }
    }

    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = tempArray[index++];
            }
        }
    }
}


void PrintArray(int[,,] array) // Печать 3D массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({i}, {j}, {k})    ");
            }
            System.Console.WriteLine();
        }
    }
}
