// Урок 6. Одномерные массивы. Продолжение
Console.Clear();

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

#region Task 41
Console.WriteLine("---Задача 41: Ввести числа. Подсчет положительных чисел---");

Console.Write("Сколько чисел вы планируете ввести?: ");
int number = int.Parse(Console.ReadLine());

int[] GetArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"{string.Join(", ", array)}");
}
int CountOfPossitiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
bool CheckZeroInArray(int[] array)
{
    foreach (int i in array)
    {
        if (array[i]==0) return true;
    }
}

int[] array = GetArray(number);
PrintArray(array);
Console.WriteLine($"Колличество положительных чисел: {CountOfPossitiveNumbers(array)}");
Console.WriteLine(CheckZeroInArray(array)? "0 - положительное число": "");// добавить при отсутствии нуля

Console.WriteLine();
#endregion


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

// Необязательная к выполнению задача
/*Дополнительная задача*: Напишите программу, которая задаёт массив из n элементов,
которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево,
или вправо на 1 позицию.
[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо*/

/*Дополнительная задача 2 (задача со звёздочкой):
Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить
случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями,
при наличии такого элемента заменить его на уникакальное значение.
[1,2,3,3] -> [1,2,3,4]*/
