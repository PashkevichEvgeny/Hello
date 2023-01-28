// Найти индекс в масcиве для первого совпадения со значением из find

int[] array = { 18, 22, 33, 94, 52, 67, 77, 48, 59, 47, 33, 10 };

int length = array.Length;
int find = 33;
int index = 0;

while (index < length)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
