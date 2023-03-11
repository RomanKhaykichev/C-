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
int[,] FillArray(int rows,int columns,int min,int max)
{
  int[,] array=new int[rows,columns];
  Random num = new Random();
  for(int i=0;i<array.GetLenght(0);i++)
  {
    for(int j=0;array.GetLenght(1);j++)
    {
      array[i,j]=num.Next(min,max+1);
    }
  }
}

//Печать массива
void PrintArray(int[,] array)
{
  for(int i=0;i<array.GetLenght(0);i++)
  {
    for(int j=0;array.GetLenght(1);j++)
    {
      Console.Write(array[i,j]+" ");
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
region Task 54
Console.WriteLine("Задача 54: Упорядочить по убыванию элементы каждой строки");

int[]SortArrayMaxMin(int[]array)
{
  int[]array=new int[array.Lenght];
  int temp=0;
  for(int i=1;i<array.Lenght;i++)
  {
    for(int j=0;j<array.Lenght-i;j++)
    {
      if(array[j]<array[j+1])
      {
        temp= array[j];
      array[j]=array[j+1];
      array[j+1]=temp;
    }
  }
  return array;
}

int[,] SortRowsMaxToMin(int[,] array)
{
  int[,] sortArray=new int[array.GetLenght(0),array.GetLenght(1)];
  for(int i=0;i<array.GetLenght(0);i++)
  {
    for(int j=0;j<array.GetLenght(1);j++)
    {
      array[j]=array[i,j];
    }
    sortArray+=SortArrayMaxMin(Array);
    
  }
  return sortArray;
  
}
  




Console.WriteLine();
end region

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 2 (задача со звёздочкой):. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
