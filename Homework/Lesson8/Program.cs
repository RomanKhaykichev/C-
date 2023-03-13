//Урок 8. Двумерные массивы. Продолжение
Console.Clear();

//Функции
//Печать сообщения, возврат числа
int GetPrintNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

//Заполнение массива
int[,] FillArray(int rows, int columns, int min, int max)
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

//Печать массива
void PrintArray(int[,] array)
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

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
#region Task 54

Console.WriteLine("Задача 54: Упорядочить по убыванию элементы каждой строки");

int[] SortRowsMaxMin(int[] array)
{
    int temp = 0;
    for (int i = 1; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i; j++)
        {
            if (array[j] < array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}
int[,] SortArrayMaxToMin(int[,] array)
{
    int[,] sortArray = new int[array.GetLength(0), array.GetLength(1)];
    int[] arrayRows = new int[array.GetLength(1)];
    int[] sortArrayRows = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayRows[j] = array[i, j];
        }
        sortArrayRows = SortRowsMaxMin(arrayRows);
        for (int l = 0; l < array.GetLength(1); l++)
        {
            sortArray[i, l] = sortArrayRows[l];
        }

    }
    return sortArray;

}

int rows = GetPrintNumber("Введите колличество строк: ");
int columns = GetPrintNumber("Введите колличество столбцов: ");
int[,] array = FillArray(rows, columns, 1, 9);
PrintArray(array);
Console.WriteLine("--------------");

PrintArray(SortArrayMaxToMin(array));

Console.WriteLine();
#endregion*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

#region Task 56

Console.WriteLine("Задача 56: Строка с наименьшей суммой элементов");

void GetNumberMinRowsArray(int[,] array)
{
    int count = 0;
    int sum = 0;
    int variable = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        variable += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.Write(sum+" ");
        if (sum <= variable) { variable = sum; count = i + 1; }
        sum = 0;
    }
    Console.Write("=> ");
    Console.WriteLine($"Строка с наименьшей суммой элементов: {count}");
}

int[,] array56 = FillArray(6, 4, 1, 9);
PrintArray(array56);
Console.WriteLine("--------------");
GetNumberMinRowsArray(array56);

Console.WriteLine();
#endregion*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
#region Task 58

Console.WriteLine("Задача 58: Произведение двух матриц");

int[,] GetMultiMatrix(int[,] array1, int[,] array2)
{
    int lenghtRow = array1.GetLength(0);
    int lenghtColumn = array1.GetLength(1);
    int[,] matrix = new int[lenghtRow, lenghtColumn];

    for (int i = 0; i < lenghtRow; i++)
    {
        for (int j = 0; j < lenghtColumn; j++)
        {
            int sum = 0;
            for (int r = 0; r < lenghtRow; r++)
            {
                sum += array1[i, r] * array2[r, j];
            }
            matrix[i, j] = sum;
        }
    }

    return matrix;
    // else return Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В");
}

int[,] array58 = FillArray(3, 3, 1, 9);
PrintArray(array58);
Console.WriteLine("-----");
int[,] array582 = FillArray(3, 3, 1, 9);
PrintArray(array582);
Console.WriteLine("--------------");
PrintArray(GetMultiMatrix(array58, array582));

Console.WriteLine();
#endregion*/

/*Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 1* (задача со звёздочкой): Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

#region Task 1*
Console.WriteLine("Доп. задача 1*: Построчно выводить массив, добавляя индексы каждого элемента");

//int[,,] array3Dem = new int[,,] { { { 66, 25, 34, 41 }, { 27, 90, 26, 50 } } };
int[,,] FillArray3Dem(int rows, int columns, int third, int min, int max)
{
    int[,,] array = new int[rows, columns, third];
    Random num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = num.Next(min, max + 1);
            }
        }
    }
    return array;
}
void PrintArray3Dem(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[i, j, z]}({i},{j},{z}) ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] array3Dem = FillArray3Dem(2, 2, 2, 10, 99);
PrintArray3Dem(array3Dem);

Console.WriteLine();
#endregion*/

/*Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 2 (задача со звёздочкой):. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
