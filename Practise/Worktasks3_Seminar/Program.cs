Console.Clear();

//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int valuePlus = new Random().Next(0,1000);
int valuePlus2 = new Random().Next(0,1000);
int valueMinus = new Random().Next(-1000,0);
int valueMinus2 = new Random().Next(-1000,0);

Console.WriteLine("Введем номер четверти:");
int Chetv = int.Parse(Console.ReadLine());
switch (Chetv)
{
    case 1:
        Console.WriteLine($"({valuePlus},{valuePlus2})");
        break;
    case 2:
        Console.WriteLine($"({valueMinus},{valuePlus2})");
        break;
    case 3:
        Console.WriteLine($"({valueMinus},{valueMinus2})");
        break;
    case 4:
        Console.WriteLine($"({valuePlus},{valueMinus})");
        break;
    default:
        Console.Write("четверть не определена");
        break;
}

/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

int S(string message)
{
    Console.Write(message);
    int link = int.Parse(Console.ReadLine());
    return link;
}

int ax = S("add ax: ");
int ay = S("add ay: ");
int bx = S("add bx: ");
int by = S("add by: ");

double answer = Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2));
Console.WriteLine($"AB = {answer}");


/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

void PrintSqr(int num)
{
 int i = 1;
 while (i<num)
 {
    
    Console.Write($"{Math.Pow(i,2)}, ");
    i++;
 }    
    Console.Write($"{Math.Pow(i,2)}");
}


Console.Write("введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintSqr(num);

/*
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1, 4.
*/

void WriteConsolePowTableN (int value)
{
    for (int i = 1; i <= value; i++)
    {
        Console.Write($"{Math.Pow(i, 2)}");
        Console.Write(i == value ? "." : ", ");
        /*
        if (i < value)
        {
            Console.Write($", ");
        }*/
        
    }
    Console.WriteLine("");
}

WriteConsolePowTableN(5);

WriteConsolePowTableN(2);