/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
System.Console.WriteLine("Задача 21. \nНапишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

int space = 3;
int[] A = new int[space];
int[] B = new int[space];

System.Console.Write($"Координаты точки A: ");
A = coordinatesOfPoints();
System.Console.WriteLine();
System.Console.Write("Координаты точки B: ");
B = coordinatesOfPoints();
System.Console.WriteLine();

System.Console.WriteLine($"Расстояние между двумя точками в трёхмерном пространстве равно {countDistanceIn3D(A, B)}.");
System.Console.WriteLine("Программа завершена.");


//Функции будут здесь

int[] coordinatesOfPoints() //Заполняет имеющийся массив рандомными значениями и выводит его в консоль
{
    Random random = new Random();
    int[] array = new int[space];
    for (int i = 0; i < array.Length; i++)
    {    
    array[i] = random.Next(-9, 10);
    }
    foreach(int i in array)
    {
        Console.Write("{0}, ", i);
    }
    return array;
}

double countDistanceIn3D(int[] x, int[] y) //Находит расстояние между двумя точками в трёхмерном пространстве
{    
    double S = 0;
    for(int i = 0; i < space; i++)
    {
        S += Math.Pow(x[i] - y[i], 2);
    }
    return Math.Abs(Math.Sqrt(S));
    //return Math.Abs((Math.Sqrt(Math.Pow(x[0] - y[0], 2) + Math.Pow(x[1] - y[1], 2) + Math.Pow(x[2] - y[2], 2))));
}

/*
double countDistanseIn2D(int[] x, int[] y) //Находит расстояние между двумя точками в двумерном пространстве
{
    return Math.Abs(Math.Sqrt(Math.Pow(x[0] - y[0], 2) + Math.Pow(x[1] - y[1], 2)));
}

int countDistanseInSegment(int x, int y) //Находит расстояние между двумя точками на отрезке
{
    return Math.Abs(x - y);
}

int findAbs(int x) //Возвращает модуль числа
{
    return Math.Abs(x);
}
*/