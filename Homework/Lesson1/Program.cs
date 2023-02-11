//Урок 1. Знакомство с языком программирования С#
Console.Clear();
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> maxNumberx = 7
a = 2 b = 10 -> maxNumberx = 10
a = -9 b = -3 -> maxNumberx = -3*/
#region Задача 2
Console.WriteLine("--- Задача 2: Сравнение чисел min/max ---");
Console.Write("Введите 1 число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue>secondValue)
{
    Console.WriteLine("Ответ: Max = "+ firstValue + "; Min = "+ secondValue);
}
else
{
    Console.WriteLine("Ответ: Max = "+ secondValue + "; Min = "+ firstValue);
}

#endregion*/
Console.WriteLine();
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
#region Задача 4
    Console.WriteLine("--- Задача 4: Максимальное число из 3-х чисел ---");
    Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());

    int maxNumber = firstNumber;
    if (maxNumber < secondNumber)
        maxNumber = secondNumber;
    if (maxNumber < thirdNumber)
        maxNumber = thirdNumber;
    Console.WriteLine("Ответ: Max = "+maxNumber);

#endregion*/
Console.WriteLine();
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/
#region Задача 6
    Console.WriteLine("--- Задача 6: Является ли число четным? ---");

    Console.Write("Введите число: ");
    int evenNumber = Convert.ToInt32(Console.ReadLine());
    if (evenNumber%2==0)
       Console.WriteLine("Да, это четное число!");
    else
       Console.WriteLine("Нет!");

#endregion*/
Console.WriteLine();
/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
#region Задача 8
    Console.WriteLine("--- Задача 8: Все четные числа введеного числа ---");
    
    Console.Write("Введите число: ");
    int evenNumbers = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ответ: ");
    for (int i = 1; i<=evenNumbers; i++)
       if (i%2==0)
       Console.Write(" ~ " +i);
    
#endregion*/