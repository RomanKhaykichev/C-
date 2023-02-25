//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

Console.Clear();
/*
Console.WriteLine("Введите число А:");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {a} = {GetSumByNumber(a)}");

int GetSumByNumber(int limit)
{
    int result = 0;
    for (int i = 1; i <= limit; i++)
    {
        result += i; //=  result = result + i;
    }
    return result;
}*/

/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456-> 3
78-> 2
89126-> 5*/
/*Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CountDigitsInNumber(a));

int CountDigitsInNumber(int number)
{
    int i = 0;
    while (number != 0)
    {
        number = number / 10;
        i++;
    }
return i;
}
*/

/*Задача 26: Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*
int GetLenghtNumberToStr(int value) 
{
    string spamNumber = value.ToString();
    return spamNumber.Length;
}
int GetLenghtNumberMath(int value)
{
    if( value == 0)
    {
        return 1;
    }
    
    int count = 0;
    for(int i = 0; value >= 1; i++)
    {
        value /= 10;
        count++;
    }
    return count;
}

int[] arrNums = new int[] {456, 78, 89126, 100, 0, 11};
Console.WriteLine($"Метод строк");
foreach (int num in arrNums)
{
    Console.WriteLine($"Длина числа {num}, равна {GetLenghtNumberToStr(num)}.");
}
Console.WriteLine($"");
Console.WriteLine($"Метод математики");
foreach (int num in arrNums)
{
    Console.WriteLine($"Длина числа {num}, равна {GetLenghtNumberMath(num)}.");
}
*/

/*Задача 28: Напишите программу, которая принимает на вход число M и N и выдаёт произведение
 чисел от M до N.
2,4 -> 24 
1,5 -> 120*/
/*
int MultNum(int a, int b)
{
    int result;
    int i;
    result = 1;
    for (i = a; i <= b; i++)
    {
        result = i * result;
    }

    return result;
}

int n;
int m;
Console.Clear();
Console.Write("введите число n ");
n = int.Parse(Console.ReadLine());
Console.Write("введите число m ");
m = int.Parse(Console.ReadLine());
Console.WriteLine($"произведение чисел от {Math.Min(n, m)} до {Math.Max(n, m)} = {MultNum(Math.Min(n, m), Math.Max(n, m))}");
*/

/*Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] fillArray(int[]array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}
return array;

}

void print(int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        else Console.Write(", ");
        Console.Write(array[i]);
        if (i == array.Length-1) Console.Write("]");
    }
}
int []array = new int [7];
fillArray(array);
print(array);

// (https://gitflic.ru/project/alexandryalovoy/dotnet-gb/file?file=Lesson_4);