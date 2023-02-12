/* Void - Метод(функция) который ничего не возвращает
1) Определили массив (строка 45)
2) FillArray - метод заполнили массив
3) PrintArray - метод Распечатали массив
*/
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index<lenght)
    {
        collection[index]=new Random().Next(1,10); // новое случайное целое число из диапазона 1-10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //вместо 0 поставили -1 (в случае если элемента нет)

    while (index<count)
    {
        if (collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // new - Создай новый массив, в котором ьудет 10 элементов

FillArray(array);

array[4]=4;//добавили доп 4 для проверки
array[6]=4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);