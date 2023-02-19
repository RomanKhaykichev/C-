// Method
/*#region Method
//Вид1 - ничего не возвращают и не принемают 
void Method1()
{
    Console.WriteLine("Автор....");
}
//Method();

//Вид2 - принемают но не возвращают
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

//Вид3 - возвращаютб но не принемают
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//Вид4 - принемают и возвращают
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

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
/*#region Worktask1

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

