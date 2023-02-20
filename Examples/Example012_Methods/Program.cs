// Method
/*#region Method
//Вид1 - ничего не возвращают и не принимают 
void Method1()
{
    Console.WriteLine("Автор....");
}
//Method();

//Вид2 - принимают, но не возвращают
void Method2(string message)
{
    Console.WriteLine(message);
}
//Method2("Hello ");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // инкримент
    }
}
//Method21("Hello", 5); //Method21(smg:"Hello",count:5);

//Вид3 - возвращают, но не принимают
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//Вид4 - принимают и возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i<count)
    {
        result=result+text;
        i++;
    }
    return result;

}
//string res = Method4(10,"sdsd");
//Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i=0; i<count; i++)
    {
       result=result+text; 
    }
    return result;

}
string res = Method4(10,"sdsd");
Console.WriteLine(res);
#endregion*/
/*for (int i = 2; i <= 10; i++)// таблица умножения
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i * j}");
    }
    Console.WriteLine();
}*/

/*#region Работа с текстом
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

//string s="qwerty"
//          012345
// s[3] //  r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

string newText1 = Replace(newText, 'с', 'С');
Console.WriteLine(newText1);
#endregion*/

/*#region Сортировка чисел
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);
#endregion*/

#region СОртировка чисел от Мах
Console.Clear();
int[] arr = { 1, 2, 5, 7, 9, 3, 6, 4, 9, 9, 5 };

void ToPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ConvertArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxNumber = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j]>maxNumber) maxNumber=array[j]; 
        }
        int temp = array[i];
        array[i]=maxNumber;
        maxNumber=temp;
    }
}
ToPrint(arr);
Console.WriteLine();

ConvertArray(arr);
ToPrint(arr);
#endregion