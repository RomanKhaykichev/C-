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


int[] array = GetArray(number);
PrintArray(array);
Console.WriteLine($"Колличество положительных чисел: {CountOfPossitiveNumbers(array)}");

Console.WriteLine();
#endregion*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

#region Task 43
Console.WriteLine("---Задача 43: Точка пересечения 2-х прямых---");

double Printvalues(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
double[] InputLineData(int line)
{
    double[] array = new double[2];
    for (int i = 0; i < 2; i++)
    {
        array[i] = Printvalues($"Введите значения для линии {line}: ");
    }
    return array;
}
double[] FindCoordinateIntersection(double[] line1, double[] line2)
{
    double[] intersection = new double[2];
    intersection[0] = (line2[0] - line1[0]) / (line1[1] - line2[1]);
    intersection[1] = line2[1] * intersection[0] + line2[0];
    return intersection;
}
void PrintCoordinate(double[] intersection)
{
    Console.WriteLine($"Координаты пересечения -> ( {string.Join(" ; ", intersection)} )");
}
bool CheckNotParallel(double[] line1, double[] line2)
{
    if (line1[1] == line2[1])
    {
        Console.Write("! Прямые параллельны !");
        return false;
    }
    else
    {
        return true;
    }
}

double[] line1 = InputLineData(1);
double[] line2 = InputLineData(2);
if (CheckNotParallel(line1,line2)) PrintCoordinate(FindCoordinateIntersection(line1, line2));

Console.WriteLine();
#endregion*/

// Необязательная к выполнению задача
/*Дополнительная задача*: Напишите программу, которая задаёт массив из n элементов,
которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево,
или вправо на 1 позицию.
[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо*/

#region Task1*
Console.WriteLine("---Task1*---");

int PrintSize(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random num = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = num.Next(min, max + 1);
    }
    return array;
}
void PrintFillArray(int[] array)
{
    Console.WriteLine($"Массив -> [ {string.Join(" , ", array)} ]");
}
int[] Moveleft(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length - 1; i++)
    {
        result[i] = array[i + 1];
        result[array.Length - 1] = array[0];
    }
    return result;
}
int[] MoveRight(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length - 1; i++)
    {
        result[i+1]=array[i];
        result[0]=array[array.Length-1];
    }
    return result;
}


int[] arr = FillArray(PrintSize("Size: "), 0, 10);
PrintFillArray(arr);
Console.WriteLine("Move Right -> 1 "+" <=> "+"Move Left -> -1");
int side = int.Parse(Console.ReadLine());

if (side==1) PrintFillArray(MoveRight(arr));
if (side==-1) PrintFillArray(Moveleft(arr));
if (side !=1 && side !=-1) Console.Write("Неверный ввод");

Console.WriteLine();
#endregion*/

/*Дополнительная задача 2 (задача со звёздочкой):
Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить
случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями,
при наличии такого элемента заменить его на уникакальное значение.
[1,2,3,3] -> [1,2,3,4]*/

#region Task 2*
Console.WriteLine("---Task2*---");

int PrintArraySize(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int[] FillArray2(int size, int min, int max)
{
    int[] array = new int[size];
    Random num = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = num.Next(min, max + 1);
    }
    return array;
}
void PrintArray2(int[] array)
{
    Console.WriteLine($"Массив -> [{string.Join(" , ", array)}]");
}
int[] ReplaceUniqueValue(int[] array)
{
    int[] unique = new int[array.Length];
    unique = array;
    for (int i = 1; i < array.Length - 2; i++)
    {
        if (array[i] == array[i - 1]) unique[i - 1] = array[i] + 1;
        if (array[i] == array[i + 1]) unique[i + 1] = array[i] + 1;
        if (array[i - 1] == array[i + 1]) unique[i + 1] = array[i] + 1;
    }
    return unique;
}

int size = PrintArraySize("Size array: ");
int[] arr2 = FillArray2(size, 1, 10);
PrintArray2(arr2);
PrintArray2(ReplaceUniqueValue(arr2));

Console.WriteLine();
#endregion
