void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        // Заполняет массив случайными значения от 1 до 10
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int size = col.Length;
    int position = 0;
    Console.Clear();
    while (position < size)
    {
        Console.WriteLine($"{position}:{col[position]}");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int len = collection.Length;
    int index = 0;
    int place = -1;

    while (index < len)
    {
        if (collection[index] == find)
        {
            place = index;
            break;
        }
        
        index++;
    }
    return place;
}

// создание нового массива из десяти элементов заполненного нулями
// array = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
int wanted = 5;
int pos = IndexOf(array, wanted);
if (pos == -1) Console.WriteLine($"{wanted} не найдена");
if (pos > -1) Console.WriteLine($"{wanted} найдена на {pos} позиции");
