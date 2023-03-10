Console.Clear();

/* TODO to analize
bool CheckIndexElement(int ind1, int ind2, int[,] array)
{
    if (ind1 >= array.GetLength(0) || ind1 < 0)
    {
        Console.WriteLine("Элемента с данными индексами в массиве не существует. Введите индексы заново");
        (ind1, ind2) = InputIndex();
        return CheckIndexElement(ind1, ind2, array);
    }
    if (ind2 >= array.GetLength(1) || ind2 < 0)
    {
        Console.WriteLine("Элемента с данными индексами в массиве не существует. Введите индексы заново");
        (ind1, ind2) = InputIndex();
        return CheckIndexElement(ind1, ind2, array);
    }
    Console.WriteLine($"Элемент в массиве с индексами [{ind1},{ind2}] -> {array[ind1, ind2]}");
    return true;
}
*/

/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа
в промежутке от 1 до N с помощью рекурсии
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
в промежутке от M до N с помощью рекурсии
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/
//63-65
void NumberCounter(int min, int max)
{
    Console.Write("{0,3}", min + ",");
    if (min == max) return;
    NumberCounter(min + 1, max);
}
NumberCounter(5, 9);

Console.WriteLine();
void ShowNumsInRange(int m, int n)
{
    if (m > n) return;
    Console.Write("   "+ m++);
    ShowNumsInRange(m, n);
}
ShowNumsInRange(1, 5);


/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать
сумму его цифр с помощью рекурсии.
453 -> 12
45 -> 9*/

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{m} -> {GetSummRang(m)}");
int GetSummRang(int number)
{
    if (number == 0) return 0;
    else return number % 10 + GetSummRang(number / 10);
}

/*Задача 69: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.Write("Введите A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} * {b} -> {GetPow(a,b)}");


int GetPow(int a,int b){
    if(b==0) return 1;
    else return a*GetPow(a,b-1);
}
