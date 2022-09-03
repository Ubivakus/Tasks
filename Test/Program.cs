// /*
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// */

// int[] array1 = {-4, -8, 8, 2};

// for(int i = 0; i < array1.Length; i++)
// {
//     array1[i] = array1[i] * (-1);
// }

// Console.WriteLine("[{0}]", string.Join(", ", array1));



// /*
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// */

// int[] array2 = { 6, 7, 5, 9, 3, 1 };
// System.Console.WriteLine("Введите искомое число:");
// int x = Convert.ToInt32(Console.ReadLine());

// if (array2.Contains(x))
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }


// // // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// // // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // // [5, 18, 123, 6, 2] -> 1
// // // [1, 2, 3, 6, 2] -> 0
// // // [10, 11, 12, 13, 14] -> 5

// int[] array3 = new int[123]; // Код заполнения массива
// for(int i=0; i<array3.Length; i++)
// {
// int number = new Random().Next(0,100);
// array3[i] = number;
// Console.Write(array3[i] + ", ");
// }

// System.Console.WriteLine();

// int count = 0; //Переменная счетчика

// foreach(int a in array3) //Пробежались по элементам массива 
// {

//     if (a > 9 && a < 100) //проверили диапазон
//     count ++;
// }
// System.Console.WriteLine(count);

//Console.WriteLine("[{0}]", string.Join(", ", array3));


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй
// и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array4 = new int[6];
// int[] array5 = new int[array4.Length / 2];

// for (int i = 0; i < array4.Length; i++)
// {
//     int number = new Random().Next(0, 100);
//     array4[i] = number;
//     Console.Write(array4[i] + ", ");
// }

// //int multiply = 1;

// for (int i = 0, j = array4.Length - 1; i < array4.Length / 2; i++, j--)
// {
//     array5[i] = array4[i] * array4[j];

// }
// Console.WriteLine("[{0}]", string.Join(", ", array5));

// 1) использовать динамические массивы и задавать ему размер внутри программы
//int[] array = new int[7];

// 2) Зарандомить массив в диапазоне выбранном пользователем 
// System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 100);
//     System.Console.Write(array[i] + ", ");
// }

// 3) Вывести массив на экран 
// 4) Найти минимальный и максимальный элементы

// Кто успеет может побаловаться Сортировкой 
// Нужно отсортировать массив 
// 1) использовать динамические массивы и задавать ему размер внутри программы 
// 2) Зарандомить массив в диапазоне выбранном пользователеем 
// 3) Вывести массив на экран 
// 4) Отсортировать массив 
// 5) вывести массив на экран


//  int num = Int32.Parse(Console.ReadLine()); // Запрашиваем ввод из консоли и вытягиваем из него число

// Пишите тут.


// string answer;

//  Console.WriteLine(answer = (num % 2 == 0) ? "EVEN" : "ODD");

// int x = 5;

// int y = 3;

// int z = x < y ? (x + y) : (x - y);

// Console.WriteLine(z);




// Создание, заполнение и вывод в консоль массива, массив не сохраняется

// int[] FillAndPrintArray()
// {
//     System.Console.Write("Задайте размер массива: ");
//     int size = Int32.Parse(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(10);
//     }
//     for (int j = 0; j < size; j++)
//     {
//         if (j == 0) System.Console.Write($"[{array[j]}, ");
//         else if (j < size - 1) System.Console.Write($"{array[j]}, ");
//         else System.Console.Write($"{array[j]}]");
//     }
//     System.Console.WriteLine();
//     return array;
// }