/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
System.Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

int day;
string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

while (true) {
    System.Console.Write("Введите цифрой день недели: ");
    day = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Вы выбрали день недели {day}. ");
if (day > 0 && day < 6)
{
    System.Console.WriteLine($"Это {week[day - 1]}.\nПросыпайся, умывайся, завтракай и бегом на работу!");
    break;
} else if (day <= 0 || day > 7)
{
    System.Console.WriteLine("Дней в неделе всего лишь 7. Выберите другой день.");
    continue;    
} else
{
    System.Console.WriteLine($"Это {week[day - 1]}.\nУра!!! Выходной!");
    break;
} 
}
System.Console.WriteLine("Программа завершена.");

