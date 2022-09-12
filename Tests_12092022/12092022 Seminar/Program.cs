System.Console.Write("Задайте размер двумерного массива через пробел: ");
string[] sizeOfMatrix = InputFromConsole();
double[,] massive = CreateMatrix(sizeOfMatrix);
double[,] newMassive = SwapRow(massive);
PrintArray(newMassive);

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