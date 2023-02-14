//Написать программу , выводит случайное число на отрезке [10,99] и показывают наибольшую цифру числа
Console.Clear();
/*#region max random
int num = new Random().Next(10,100);
Console.WriteLine(num);
int firstValue = num/10;
int secondValue = num%10;

int max = firstValue;
if (secondValue>max) max=secondValue;

Console.WriteLine($"max number {max}");
#endregion*/

/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98*/
/*#region Случайное 3-х значное число

int random = new Random().Next(100,1000);
Console.WriteLine(random);

int first = random/100;
int third = random%10;

int number = first*10 + third;

Console.WriteLine(number);

#endregion*/

/*Напишите программу, которая будет принимать на вход два числа и выводить,
 является ли второе число кратным первому. Если число 2 не кратно числу 1,
  то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/
/*#region Ввод 2 числа
   Console.Write("Введите 1 число: ");
   int num1 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите 2 число; ");
   int num2 = Convert.ToInt32(Console.ReadLine());

   if (num1 % num2 == 0) Console.WriteLine($"Число {num2} кратное");
   else Console.WriteLine($"Остаток {num1%num2}");
#endregion*/

/*Напишите программу, которая принимает на вход число и проверяет,
 кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/
/*#region проверка на кратность
while (1 == 1)
{
    int num = new Random().Next(1, 200);
    Console.WriteLine(num);

    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("YES");
        break;
    }
}
#endregion

/*Напишите программу, которая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/


#region Проверка на квадрат
Console.WriteLine(" Введите число1: ");
Double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Введите число2: ");
Double num2 = Convert.ToDouble(Console.ReadLine());
if ((Math.Sqrt(Math.Abs(num1)) == num2) || (Math.Sqrt(Math.Abs(num2)) == num1))
{
    Console.WriteLine($" {num1}, {num2} -> да");
}
else
{
    Console.WriteLine($" {num1}, {num2} -> нет");
}

#endregion*/