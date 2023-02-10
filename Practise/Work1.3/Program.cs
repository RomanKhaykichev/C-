/* Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет

Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница

Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"

Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8*/

Console.Clear();
Console.Write("Введите первое число: ");
int Digit1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Digit2 = Convert.ToInt32(Console.ReadLine());
if (Digit2 == Math.Sqrt(Digit1))
    Console.WriteLine ("Это КОРЕНЬЬЬ, ЗДОРОВЕННЫЙ КОРЕНЬ");
else Console.WriteLine ("Это совсем не КОРЕНЬ");


string a="monday";
string b="tuesday";
string c="wednesday";
string d="t";
string e="friday";
string f="saturday";
string g="voskr";

Console.Write("Введите первое число: ");
int Digit1 = Convert.ToInt32(Console.ReadLine());

/*Console.Clear();
Console.WriteLine("введите трехзначное число n");
int n = Convert.ToInt32(Console.ReadLine());
int d = n%10;

        Console.WriteLine(" " + d + " " );