Console.Clear();

//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
/*31
Console.Clear();

int[] array = FillArray(12,-9,9);

Console.WriteLine($"В массиве: [{string.Join(" ", array)}] сумма положительных чисел равна {GetSumPossitiveByArray(array)}, сумма отрицательных равна {GetSumNegativeByArray(array)}");

int[] FillArray(int size, int min, int max){
    int[] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < result.Length; i++){
        result[i] = rnd.Next(min,max + 1);
    }
    return result;
}

int GetSumPossitiveByArray(int[] inputArray){
    int result = 0;
    foreach(int element in inputArray){
        result += element > 0 ? element : 0;
        // if(element > 0) 
        //     result += element;
    }
    return result;
}

int GetSumNegativeByArray(int[] inputArray){
    int result = 0;
    foreach(int element in inputArray){
        result += element < 0 ? element : 0;
        // if(element > 0) 
        //     result += element;
    }
    return result;
}
*/


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

/*32
void print(int[] array)
{
   Console.WriteLine($"[{string.Join(",",array)}]");
}
int[] arrayInit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i=0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }
    return array;
}
int[] oppositeSignArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

Console.WriteLine("Введите разменрность массива:");
int arraySize = int.Parse(Console.ReadLine());
int[] array = arrayInit(arraySize);

print(array);
oppositeSignArray(array);
print(array);
Console.WriteLine();*/

/*33
int[] array = FillArray(5, 6, 345);


Console.WriteLine($"В массиве: [{string.Join(" ", array)}]");
Console.WriteLine($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (HasValueInArray(array, num))
    Console.WriteLine($"Да ");
else
    Console.WriteLine($" Нет");

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}
bool HasValueInArray(int[] innumArray, int num)
{
    for (int i = 0; i < innumArray.Length; i++)
    {
        if (innumArray[i] == num)
            return true;
    }

    return false;
}*/

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

/*35
int[] arrayInit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i=0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,200);
    }
    return array;
}

int intExist(int[] array)
{
    int result = 0;
   for(int i =0; i <array.Length; i++)
   {
        if (array[i] >= 10 && array[i] <=99) result++;  
   }
   return result;
}
void print(int[] array)
{
   Console.WriteLine($"[{string.Join(",",array)}]");
}

int[] array = arrayInit(10);
print(array);
Console.WriteLine($"В данном массиве {intExist(array)} чисел диапозона ");
*/

/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

/*37
void print(int[] array)
{
   Console.WriteLine($"[{string.Join(",",array)}]");
}
int[] arrayInit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i=0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,10);
    }
    return array;
}

int [] multyPairs(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 == 1) size ++;
    int[] array2 = new int[size];
    for(int i =0; i < array2.Length; i++ )
    {
        if (i == array.Length-i-1)
        { 
            array2[i] = array[i];
            break;
        }
        array2[i] = array[i] * array[array.Length-i-1]; 

    }
    return array2;
}

Console.WriteLine($"Введите размер массива:");
int size = int.Parse(Console.ReadLine());

int[] array = arrayInit(size);
print(array);
print(multyPairs(array));
*/