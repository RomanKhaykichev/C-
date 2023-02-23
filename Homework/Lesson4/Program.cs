//Урок 4. Функции
Console.Clear();
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*#region Task25
Console.WriteLine("---Задача 25: число А в в натуральную степень В---");

int Print(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int Pow(int a, int b)
{
    int degreeNum = a;
    for (int i = 1; i < b; i++)
    {
        degreeNum *= a;
    }
    return degreeNum;

}

int a = Print("Введите число А: ");
int b = Print("Введите степень В: ");
Console.WriteLine($"Число А->{a} в степени В->{b} = {Pow(a,b)}");
Console.WriteLine();
#endregion*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
#region Task27
Console.WriteLine("---Задача 27: сумма цифр в числе---");

int Print2(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumValueInNumber(int number)
{
    //write
}


Console.WriteLine(SumValueInNumber(Print2("Введите число: ")));
Console.WriteLine();
#endregion*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

#region Task 29:
Console.Write("---Задача 29:Массив из N элементов---");


#endregion
