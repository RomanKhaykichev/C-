//Урок 5. Функции и одномерные массивы
Console.Clear();

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

#region Task 34
Console.WriteLine("---Задача 34: Колличество четных числе в массиве---");

int Print(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int[] ToFillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num.Next(min, max + 1);
    }
    return array;
}
int CountEvenNumber(int[] array)
{
    int count=0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]%2==0) count++;
    }
    return count;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}


int[] arr = ToFillArray(Print("Введите размер массива: "), 100, 1000);
PrintArray(arr);
Console.WriteLine($"Колличество четных чисел: {CountEvenNumber(arr)}");

Console.WriteLine();
#endregion*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

#region Task 36
Console.WriteLine("---Задача 36: Сумма элементов, стоящих на нечетных позициях---");

int Print2(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int[] ToFillArray2(int size, int min, int max)
{
    int[] array = new int[size];
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num.Next(min, max + 1);
    }
    return array;
}
int GetSumNegativePositionArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}
void PrintArray2(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}

int[] arr2=ToFillArray2(Print2("Введите длину массива: "),-100,100);
PrintArray2(arr2);
Console.WriteLine($"Сумма элементов нанечетных позициях: {GetSumNegativePositionArray(arr2)}");

Console.WriteLine();
#endregion*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
минимальным элементов массива.
[3 7 22 2 78] -> 76*/

#region Task 38
Console.WriteLine("---Задание 38: Разница между максимальным и минимальным элементом массива---");

int Print3(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int[] ToFillArray3(int size, int min, int max)
{
    int[] array = new int[size];
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num.Next(min, max + 1);
    }
    return array;
}
void PrintArray3(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}
int DifferenceBetweenMinMaxNumberArray(int[] array)
{
    int max = array[0], min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
     return max - min;
}
int DifferenceBetweenForeach(int[] array)
{
    int min=array[0],max=array[0];
    foreach(int element in array)
    {
        if(element>max) max=element;
        if(element<min) min=element;
    }
    return max-min;
}

int[] arr3 = ToFillArray3(Print3("Введите длину массива: "),0,100);
PrintArray3(arr3);
Console.WriteLine($"Разница м/у макс и мин - цикл 'For': {DifferenceBetweenMinMaxNumberArray(arr3)}");
Console.WriteLine($"Разница м/у макс и мин - цикл 'Foreach': {DifferenceBetweenForeach(arr3)}");

#endregion*/