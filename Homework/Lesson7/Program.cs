//Урок 7. Двумерные массивы
Console.Clear();

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
/* #region Task 47
Console.WriteLine("---Задача 47: Задайте двумерный массив размером m×n---");

int PrintSize(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
double[,] FillArray(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    Random num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = num.Next(min, max + 1) + Math.Round(num.NextDouble(), 1);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    string str = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str = array[i, j] < 0 ? " " : "  ";
            str = array[i, j] % 10 == 0 ? "   " : " ";
            str = array[i, j] < 0 && array[i, j] % 10 != 0 ? " ":"  ";
            Console.Write($"{str}{array[i, j]}");
        }
        Console.WriteLine();
    }
}

int rows = PrintSize("Введите колличество строк: ");
int columns = PrintSize("Введите колличество столбцов: ");
PrintArray(FillArray(rows, columns, -9, 9));


Console.WriteLine();
#endregion*/

/*Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1,1 -> 9
1,7 -> элемента с данными индексами в массиве нет*/
/*#region Task 50
Console.WriteLine("---Задача 50: Возвращает значение элемента по индексу---");

int[,] FillArray2(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = num.Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int PrintGetIndex(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
void FindIndexValue(int[,] array, int rows, int columns)
{
    int lenghtRows = array.GetLength(0);
    int lenghtColumns = array.GetLength(1);

    if (lenghtRows < rows || lenghtColumns < columns)
        Console.WriteLine("Элемента с данным индексом в массиве нет");
    if (lenghtRows >= rows && lenghtColumns >= columns)
        Console.WriteLine($"Элемент с данным индексом [{rows},{columns}] = {array[rows, columns]}");
}


int[,] arr2 = FillArray2(3, 4, 1, 9);
PrintArray2(arr2);
Console.WriteLine("-----------");

int rows = PrintGetIndex("Введите номер строки: ");
int columns = PrintGetIndex("Введите номер столбца: ");
FindIndexValue(arr2, rows, columns);

Console.WriteLine();
#endregion*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
/*#region Task 52
Console.WriteLine("---Задача 52: Среднее арифметическое каждого столбца---");

int[,] FillArray3(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = num.Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void AverageColumns(int[,] array)
{
    double sum = 0;
    double average = 0;
    string str = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            str = array[i, j] % 10 == 0 ? "":"  ";
        }
        average = Math.Round(sum / array.GetLength(0), 1);
        Console.Write($" {average}{str}");
        sum = 0;
    }
}

int[,] arr3 = FillArray3(3, 4, 1, 9);
PrintArray3(arr3);
Console.WriteLine("--------------");
AverageColumns(arr3);

Console.WriteLine();
#endregion*/

//Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
/*Дополнительная задача 1*:
Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого,
больше суммы элементов расположенных в четырех "углах" двумерного массива.

Например, задан массив:
4 4 7 5
4 3 5 3
8 1 6 8 -> нет

2 4 7 2
4 3 5 3
2 1 6 2 -> да*/
#region Task 2*
Console.WriteLine("---Задача 1: Сумма столбца больше суммы элементов расположенных в четырех углах двумерного массива---");

void PrintArray4(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
int[] SumColumnArray(int[,] array)
{
    int sumColumn = 0;
    int[] sumColumnArray = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumColumn += array[i, j];
        }
        sumColumnArray[j] = sumColumn;
        sumColumn = 0;
    }
    return sumColumnArray;
}
void PrintArraySumColumn(int[] array)
{
    Console.WriteLine($"{string.Join(" ", array)}");
}
void CompareSumColumnSumCorners(int[,] array, int[] sumColunArray)
{
    int compare=0;
    int rowsLenght = array.GetLength(0) - 1;
    int columnsLenght = array.GetLength(1) - 1;
    int sumCorners = array[0, 0] + array[0, columnsLenght] + array[rowsLenght, 0] + array[rowsLenght, columnsLenght];
    Console.WriteLine(sumCorners);
    for (int i = 0; i < sumColunArray.Length; i++)
    {
        if(sumColunArray[i] > sumCorners ) compare++;
    }
    Console.WriteLine(compare>0? "Yes" : "NO");
}

int[,] array = new int[,] { { 4, 4, 7, 5 }, { 4, 3, 5, 3 }, { 8, 1, 6, 8 } };
PrintArray4(array);
Console.WriteLine("-----------");
PrintArraySumColumn(SumColumnArray(array));
CompareSumColumnSumCorners(array, SumColumnArray(array));
Console.WriteLine("----------------------------------");
int[,] array2 = new int[,] { { 2, 4, 7, 2 }, { 4, 3, 5, 3 }, { 2, 1, 6, 2 } };
PrintArray4(array2);
Console.WriteLine("-----------");
PrintArraySumColumn(SumColumnArray(array2));
CompareSumColumnSumCorners(array2, SumColumnArray(array2));

Console.WriteLine();
#endregion*/

/*Дополнительная задача 2*: Вывести первые n строк треугольника Паскаля. Реализовать вывод в виде равнобедренного треугольника.

N = 7 -> https://ibb.co/yWPZbG7*/
/*#region Task 1*
    

    Console.WriteLine(;)
#endregion*/
