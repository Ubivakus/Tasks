/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Clear();
System.Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
System.Console.Write("Введите произвольное количество любых целых чисел через пробел: "); //Приветствие

string input = Console.ReadLine(); //Получаем символы с консоли
string[] arrayOfNumbers = input.Split(' '); //Сохраняем символы в массив с разделителем через пробел
System.Console.WriteLine("Вы ввели числа: " + String.Join(", ", arrayOfNumbers) + "."); //Выводим красиво введённые символы

int countOfNumbers = CountOfPositiveNumbers(arrayOfNumbers); //Запускаем метод, передавая в него массив символов и сохраняя в новую переменную
System.Console.WriteLine($"Количество чисел больше 0 равно: {countOfNumbers}");
System.Console.WriteLine("Программа завершена.");

int CountOfPositiveNumbers(string[] array) //Метод подсчитывает количество чисел больше 0
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) //Проходимся по массиву, конвертируем символы в числа и проверяем условие > 0
    {
        int convertNumber = Convert.ToInt32(array[i]);
        if (convertNumber > 0) count++;
    }
    return count; //Возвращаем полученное значение
}
