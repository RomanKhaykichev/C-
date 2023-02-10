//Найти квадратный корень числа

Console.Clear();
Console.WriteLine("Введите число: ");

int value = Convert.ToInt32(Console.ReadLine()); // Конвертирует вводимое число в числовую

Console.WriteLine("Квадратный корень числа: " + value*value);
Console.WriteLine("Другой вариант: "+ Math.Pow(value,2));// Мат формула
