Console.Clear();

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("квадрат числа " + value +" равен: " + value* value);

Console.WriteLine("Способ 2. Квадрат числа " + value + " равен: " + Math.Pow(value,2)); // 2 вариант

