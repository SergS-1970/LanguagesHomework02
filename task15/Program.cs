/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите целое число, соответствующее дню недели (1 - понедельник, 2 - вторник и т.д.) ");
int dayWeekNumber = Convert.ToInt32(Console.ReadLine());

if (dayWeekNumber <= 0 || dayWeekNumber >= 8) Console.WriteLine("Ошибка. Такой день недели мне неизвестен.");
if (dayWeekNumber == 6 || dayWeekNumber == 7) Console.WriteLine("Да, сегодня выходной!");
if (dayWeekNumber > 0 && dayWeekNumber < 6) Console.WriteLine("Нет, сегодня рабочий день.");
