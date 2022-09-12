// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

System.Console.Write("Задайте размер двумерного массива через пробел: ");
string[] sizeOfMatrix = InputFromConsole();
double[,] massive = CreateMatrix(sizeOfMatrix);
double[,] someArray = TurnMatrix(massive);
PrintArray(someArray);
//TurnMatrix(massive);

//PrintArray(newMassive);

string[] InputFromConsole() // Функция принимает данные из консоли и сохраняет в массив.
{
    string input = Console.ReadLine();
    string[] splitArray = input.Split(' ');
    return splitArray;
}

double[,] CreateMatrix(string[] array) // Создаем, заполняем и выводим в консоль двумерный массив размером заданным пользователем.
{
    System.Console.WriteLine();
    int rows = int.Parse(array[0]);
    int columns = int.Parse(array[1]);
    double[,] newArray = new double[rows, columns];
    System.Console.WriteLine("Ваш новый массив: ");

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(10, 100);
            System.Console.Write($"{newArray[i, j]}     ");
        }
        System.Console.WriteLine();
    }
    return newArray;
}

double[,] TurnMatrix(double[,] array)
{
    double[,] someArray = new double[array.GetLength(0), array.GetLength(1)];

    // for (int i = 0; i < array.GetLength(1); i++)
    // {
    //     double tmp = someArray[1,  i];
    //     someArray[1, i] = someArray[3, i];
    //     someArray[3, i] = tmp;


    // }

    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     double tmp = someArray[i, 2];
    //     someArray[i, 2] = someArray[i, array.GetLength(0) - 1];
    //     someArray[i, array.GetLength(0) - 1] = tmp;
    // }
    Console.WriteLine("Transformed array: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            //Console.Write("{0,4}", array[j, i]);
            someArray[i, j] = array[j, i];
        }
        //Console.WriteLine();
    }
    return someArray;
}

double[,] SwapRow(double[,] array)
{
    int row = array.GetLength(0);
    int colomns = array.GetLength(1);
    double[] tmp_row = new double[colomns];
    for (int i = 0; i < colomns; i++)
    {
        tmp_row[i] = array[0, i];
        array[0, i] = array[row - 1, i];
        array[row - 1, i] = tmp_row[i];
    }
    return array;
}

void PrintArray(double[,] array)
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



