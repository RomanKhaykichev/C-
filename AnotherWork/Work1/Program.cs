/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

#region Задача 19.1
Console.WriteLine("---Задача19.1: Проверка на палиндром --- ");
int Print(string number)
{
    Console.Write(number);
    int numberST = int.Parse(Console.ReadLine());
    return numberST;
}
string Palindrom(int num)
{
    string number = num.ToString();
    bool flag = false;
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] == number[number.Length - 1 - i])
        {
            flag = true;
        }
        else
        {
            flag = false;
        }
    }
    return (flag ? "Yes" : "No");
}

int number = Print("hh: ");
Palindrom(number);

#endregion*/