//Найти смаксимальное из 9 чисел
Console.Clear();

int Max(int arg1, int arg2, int arg3) //Функция Мах сравнения по 3
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int a1 =2;
int b1 =6;
int c1 =45;
int a2 =25;
int b2 =14;
int c2 =456;
int a3 =12;
int b3 =14;
int c3 =78;

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1,max1,max3);

int max=Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));

Console.Write(max);