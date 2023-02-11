//Урок 1. Знакомство с языком программирования С#
Console.Clear();
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
/*<-delete #region Задача 2
Console.WriteLine("--- Задача 2: Сравнение чисел min/max ---");
Console.Write("Введите 1 число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue>secondValue)
{
    Console.Write("Ответ: Max = "+ firstValue + "; Min = "+ secondValue);
}
else
{
    Console.Write("Ответ: Max = "+ secondValue + "; Min = "+ firstValue);
}
#endregion*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
/*<-delete #region Задача 4
    Console.WriteLine("--- Задача 3: Максимальное число из 3-х чисел ---");
    Console.Write("Введите первое число: ");
    int firstValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int thirdValue = Convert.ToInt32(Console.ReadLine());

    int maxValue = firstValue;
    if (maxValue < secondValue)
        maxValue = secondValue;
    if (maxValue < thirdValue)
        maxValue = thirdValue;
    Console.WriteLine("Ответ: Max = "+maxValue);

#endregion*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/
/*<-delete #region Задача 6
    Console.WriteLine("--- Задача 6: Является ли число четным? ---");

    Console.Write("Введите число: ");
    int evenNumber = Convert.ToInt32(Console.ReadLine());
    if (evenNumber%2==0)
       Console.WriteLine("Да, это четное число!");
    else
       Console.WriteLine("Нет!");
#endregion*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/