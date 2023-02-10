Console.Clear();
/* Задача №1. Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет*/
  /*<-d  #region Задача №1;
Console.WriteLine("Task 1: Является ли 1 число квадратным корнем второго?");
Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 == Math.Sqrt(value2)) // Квадрат иначе Math.Pow(value2,2)
    Console.WriteLine("You are right!");
else
    Console.WriteLine("Not right!");
#endregion*/

/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/
  /*<-d  #region Задача №3;
Console.Write("Task 3: Введите номер дня недели: ");
int valueWeek = Convert.ToInt32(Console.ReadLine());

switch(valueWeek) //Конструкция switch/case оценивает некоторое выражение и сравнивает его значение с набором значений
{
    case 1:
       Console.WriteLine("Понедельник");
       break;
    case 2:
       Console.WriteLine("Вторник");
       break;
    case 3:
       Console.WriteLine("Среда");
       break;
    case 4:
       Console.WriteLine("Четверг");
       break;
    case 5:
       Console.WriteLine("Пятница");
       break;
    case 6:
       Console.WriteLine("Суббота");
       break;
    case 7:
       Console.WriteLine("Воскресенье");
       break;
    default:
       Console.WriteLine("Error, day week dont exist");
       break;
}
#endregion*/

/*Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"*/
  /*<-d   #region Задача №5;
Console.WriteLine("Task 5: Напишите число для построения разброса: ");
int valueRange = Convert.ToInt32(Console.ReadLine());
for (int i = -valueRange; i <= valueRange; i++)
{
    Console.Write(i+",");
}
    
#endregion*/

Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8*/





/*Console.Clear();
Console.WriteLine("введите трехзначное число n");
int n = Convert.ToInt32(Console.ReadLine());
int d = n%10;

        Console.WriteLine(" " + d + " " );*/