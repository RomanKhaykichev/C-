﻿//Урок 2. Базовые алгоритмы
Console.Clear();

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

#region Задача 10.
Console.WriteLine("---Задача 10: Вторая цифра трехзначного числа---");

int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число: {number}");
int value2 = (number % 100 - number % 10) / 10;

Console.WriteLine($"Вторая цифра числа: {value2}");
#endregion*/
Console.WriteLine();

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

#region Задача 13.
Console.WriteLine("--- Задача 13: 3-я цифра заданного числа---");

Console.WriteLine("Введите число: ");
int numberCheck = Convert.ToInt32(Console.ReadLine());

if (numberCheck > 10000 && numberCheck <= 100000)
{
    int valueThird = (numberCheck % 1000 - numberCheck % 100) / 100;
    Console.WriteLine($"3-я цифра: {valueThird}");
}
if (numberCheck > 1000 && numberCheck <= 10000)
{
    int valueThird = (numberCheck % 100 - numberCheck % 10) / 10;
    Console.WriteLine($"3-я цифра: {valueThird}");
}
if (numberCheck > 100 && numberCheck <= 1000)
{
    int valueThird = numberCheck % 10;
    Console.WriteLine($"3-я цифра: {valueThird}");
}
if (numberCheck < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

#endregion*/

Console.WriteLine();

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

#region Задача 15.
Console.WriteLine("--- Задача 15: Проверка дня недели (выходной) ---");

Console.WriteLine("Введите цифру дня недели: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());

if (numberWeek == 6 || numberWeek == 7) Console.WriteLine("Это выходной день!");
if (numberWeek > 0 && numberWeek < 6) Console.WriteLine("Будни....");
else Console.Write("Число не соответствует дню недели");
#endregion*/
