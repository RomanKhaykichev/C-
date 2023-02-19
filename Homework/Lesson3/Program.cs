//Урок 3. Базовые алгоритмы. Продолжение
Console.Clear();

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
#region Задача 19
Console.WriteLine("---Задача19: Проверка пятизначного числа на палиндром --- ");

int Print(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
void Palindrom(int number)
{
    int numR1 = number / 10000;
    int numR2 = number / 1000 % 10;
    int numL1 = number % 10;
    int numL2 = number / 10 % 10;
    Console.WriteLine(numR1 == numL1 && numR2 == numL2 ? $"Да! Число => {number} -  палиндром!" : $"Нет! Число=>{number} не палиндром");
}
bool CheckNumberFive(int number)
{
    if (number > 10000 && number < 100000) return true;
    else return false;
}

void StartCircle(int number)
{
    if (CheckNumberFive(number)) Palindrom(number);
    else StartCircle(Print("Это не пятизначное число! Введите еще раз: "));
}

int number = Print("Введите число на проверку: ");
StartCircle(number);

#endregion*/
Console.WriteLine();

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
#region Задача 21
Console.WriteLine("---Задача 21: Нахождение расстояния в 3D пространстве---");

int Print1(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

Console.WriteLine("Введите координаты A(x,y,z)");
int xa = Print1("x: ");
int ya = Print1("y: ");
int za = Print1("z: ");
Console.WriteLine("Введите координаты B(x,y,z)");
int xb = Print1("x: ");
int yb = Print1("y: ");
int zb = Print1("z: ");

double distance = Math.Round(Math.Sqrt(Math.Pow(xa - xb, 2) +Math.Pow(ya-yb,2)+Math.Pow(za-zb,2)), 2);
Console.WriteLine($"Расстояние между координатами А({xa},{ya},{za}) и B({xb},{yb},{zb}) = {distance}");

#endregion*/
Console.WriteLine();

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
#region Задача 23
Console.WriteLine("---Задача 23: Список кубов, введенного числа---");
int Print2(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
void ValuePow3(int number)
{
    for (int value = 1; value <= number; value++)
    {
        double num = Math.Pow(value, 3);
        Console.Write(value < number ? $"{num}," : $"{num}.");
    }
}

ValuePow3(Print2("Введите число: "));

#endregion*/