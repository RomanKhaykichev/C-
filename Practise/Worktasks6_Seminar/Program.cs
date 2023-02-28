Console.Clear();
//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

//Способ1

Console.Clear();

int[] array = FillArray(5,1,10);

Console.WriteLine($"Исходный массив:     [{string.Join(",",array)}]");
Console.WriteLine($"Перевёрнутый массив: [{string.Join(",",ReverseArray(array))}]");

int[] FillArray(int size,int min,int max){
    int [] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i< result.Length ; i++){
        result[i] = rnd.Next(min,max+1);
    } 
    return result;
}

int[] ReverseArray(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0;i<array.Length;i++){
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}
*/
//Способ2
//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] array = FillArray(5,1,10);

Console.WriteLine($"Исходный массив:     [{string.Join(",",array)}]");
Console.WriteLine($"Перевёрнутый массив: [{string.Join(",",ReverseArray(array))}]");

int[] FillArray(int size,int min,int max){
    int [] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i< result.Length ; i++){
        result[i] = rnd.Next(min,max+1);
    } 
    return result;
}

int[] ReverseArray(int[] array){
    int[] result = new int[array.Length];
    int temp = 0;
    for(int i = 0;i<array.Length / 2;i++){
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}
*/

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,\
// может ли существовать треугольник с сторонами такой длины.
// 	Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите длину стороны 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны 2");
int c = Convert.ToInt32(Console.ReadLine());

if (Triangle(a, b, c))
{
    Console.WriteLine($"Треугольнику быть");
}
else Console.WriteLine($"Треугольник импосибле");
bool Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && c + b > a)
    {
        return true;
    }
    else
        return false;
}
*/

// Задача 45: Напишите программу, которая будет создавать копию заданного массива
//с помощью поэлементного копирования.

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(",", array)}]");
}

int[]arr=FillArray(4,1,10);
PrintArray(arr);
PrintArray(CopyArray(arr));
Console.WriteLine();

int [] CopyArray(int[]array)
{
    int[]copyarray=new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyarray[i]= array[i];
    }
    return copyarray;
}
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 41 -> 101001
// 3  -> 11
// 2  -> 10

string ConverseTenToTwo(int number)
{
    string result = "";
    int remant = number;
    while (remant > 0)
    {
        result = remant % 2 + result;
        //Console.WriteLine(result);
        remant = remant / 2;
    }
    return result;
}
string ans = ConverseTenToTwo(10);
Console.WriteLine(ans);*/

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int num;
Console.Clear();
Console.Write("Input number: ");
num = Convert.ToInt32(Console.ReadLine());
int[] fibo = GetFibo(num);
Console.Write($"N = {num} -> {string.Join(", ", fibo)}");

int[] GetFibo(int number)
{
    int[] result = new int[number];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < number; i++)
    {
        result[i] = result[i-2] + result[i-1];
    }
    return result;
}