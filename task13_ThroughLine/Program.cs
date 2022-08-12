/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите натуральное число N: ");
string numberN = Console.ReadLine();

int lenghtString = numberN.Length;

if (lenghtString < 3)
{
   Console.WriteLine("Число N двузначное; третьей цифры нет"); 
}

else 
{
    Console.WriteLine("Третья цифра числа N = " + numberN[2]);
}