Console.Clear();
//Задача 46: Задайте двумерный массив размера m на n
/*
Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);

int[,] FillArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
*/

/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/
/*
int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i , j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(FillArray(3,4));
*/

/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Итоговый массив: 	
8 4 2 4
5 9 2 3
1 4 7 2*/
/*
int[,] FillArray1(int rows, int columns, int min, int max)
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
void PrintArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SwapRow(int[,]array)
{
    int temp=0;
    int[,]result=(int[,])array.Clone();
    for (int j = 0; j < result.GetLength(1); j++)
    {
        temp=result[0,j];
        result[0,j]=result[result.GetLength(0)-1,j];
        result[result.GetLength(0)-1,j]=temp;
    }
    return result;
}


Console.WriteLine("Массив:");
int[,] arr = FillArray1(3, 4, 1, 9);
PrintArray1(arr);
Console.WriteLine("-------------->");
PrintArray1(SwapRow(arr));
*/

/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
1 4 7 2     1 4 49 2
5 9 2 3 ->  5 9 2 3
8 4 2 4     64 4 4 4*/
/*
int[,] FillArrray2(int rows, int columns, int min, int max)
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
int[,] PowValueOfEvenIndex(int[,] array)
{
    int[,] result = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) result[i,j]=Convert.ToInt16(Math.Pow(array[i,j],2));
            else result[i,j]=array[i,j];
        }
    }
    return result;
}

int[,] arr2 = FillArrray2(3, 4, 1, 9);
PrintArray2(arr2);
Console.WriteLine("----------");
PrintArray2(PowValueOfEvenIndex(arr2));
*/

/*Задача 51: Задайте двумерный массив. Найдите сумму
 элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/
/*
int[,] FillArray3(int rows,int columns,int min,int max){
    int[,] array=new int[rows,columns];
    Random num= new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j]=num.Next(min,max+1);
        }
    }
    return array;    
}
void PrintArray3(int[,]array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}
int SumIndexDiagonal (int[,]array){
    int sum=0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(i==j) sum+=array[i,j];
        }
    }
    return sum;
}
int SumIndexDiagonal2 (int[,]array){
    int sum=0;
    for (int i = 0,j=0; i < array.GetLength(0); i++,j++){
        sum+=array[i,j];
        }
    return sum;
}


int[,] arr3=FillArray3(3,4,1,9);
PrintArray3(arr3);
Console.WriteLine("---------");
Console.WriteLine($"Сумма элементов главной диагонали: {SumIndexDiagonal(arr3)}");

Console.WriteLine($"Сумма элементов главной диагонали 2: {SumIndexDiagonal2(arr3)}");