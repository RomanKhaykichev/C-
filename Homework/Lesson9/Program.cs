// Урок 9. Рекурсия
Console.Clear();

int GetPrintNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8*/
#region Task 64
Console.WriteLine("---Задача 64: все чётные натуральные числа в промежутке от M до N---");

int m = GetPrintNumber("Введите 1 число: ");
int n = GetPrintNumber("Введите 2 число: ");
GetNumberBetween(m, n);

void GetNumberBetween(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0) Console.Write(m == n || m == n - 1 ? $"{m}." : $"{m}, ");
    GetNumberBetween(m + 1, n);
}

Console.WriteLine();
#endregion*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке 
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

#region Task 66
Console.WriteLine("---Задача 66: сумма натуральных элементов в промежутке от M до N---");

int m2 = GetPrintNumber("Введите 1 число: ");
int n2 = GetPrintNumber("Введите 2 число: ");
Console.Write($"Sum => {GetSumNumber(m2, n2)}");

int GetSumNumber(int m, int n)
{
    if (m > n) return 0;
    else return m + GetSumNumber(m + 1, n);
}

Console.WriteLine();
#endregion*/

/*Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель
(НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7*/

#region Task 68
Console.WriteLine("---Задача 68: наибольший общий делитель (НОД) этих чисел---");

int m3 = GetPrintNumber("Введите 1 число: ");
int n3 = GetPrintNumber("Введите 2 число: ");
GetMaxDevide(m3, n3);

void GetMaxDevide(int m, int n)
{
    int max = m, min = n;
    if (m < n) { max = n; min = m; }
    if (max%min!=0) GetMaxDevide(max%min, min);
    else Console.WriteLine(min);
}


Console.WriteLine();
#endregion*/

/*Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/

#region Task 1*
Console.WriteLine("---Доп. задача 1*: Вычисления функции Аккермана---");

int m4 = GetPrintNumber("Введите 1 число: ");
int n4 = GetPrintNumber("Введите 2 число: ");
Console.WriteLine(GetNumberAkkermana(m4, n4));

int GetNumberAkkermana(int m, int n)
{
    if (m > 0 && n == 0) return GetNumberAkkermana(m - 1, 1);
    if (m > 0 && n > 0) return GetNumberAkkermana(m - 1, GetNumberAkkermana(m, n - 1));
    else return n + 1;;
}

Console.WriteLine();
#endregion*/

/*Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая выводит монотонную последовательность
из N элементов в виде равностороннего треугольника с помощью рекурсии
N = 5 -> https://ibb.co/9nZgLtY */
