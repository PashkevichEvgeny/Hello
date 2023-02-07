/* Алгоритм сортировки
1. Найти минимальное значение в массиве
2. Поменять местами первый неотсортированный элемент и минимальный элемент в массиве
3. Повторять пока не закончатся неотсортированные элементы в массиве
*/

// Создает массив заданного размера и заполняет случайными значениями от 1 до 9 включительно
int[] FillArray(int sizeArray)
{
    int[] arr = new int[sizeArray];
    // Заполняет массив случайными значения от 1 до 10
    for (int i = 0; i < sizeArray; i++) arr[i] = new Random().Next(1, 10);
    return arr;
}
// Метод выводящий массив
void PrintArray(int[] array)
{
    foreach (int i in array) Console.Write(i + " ");
    Console.WriteLine();
}

// Метод сортирующий массив от меньшего к большему
void SortFromMinToMax(int[] array)
{
    int length = array.Length;
    // В цикле проходим по всем значениям и меняем местами 
    for (int i = 0; i < length - 1; i++)
    {
        // Индекс минимального значения в неотсортированных элементах [j : length] 
        int minimalPosition = i;
        for (int j = i + 1; j < length; j++)
        {
            // Запись в переменную индекса с минимальным значением
            if (array[j] < array[minimalPosition]) minimalPosition = j;
        }
        // Обмен значениями минимального с первым неотсортированным
        (array[minimalPosition], array[i]) = (array[i], array[minimalPosition]);
    }
}

// Метод сортирующий массив от большего к меньшему
void SortFromMaxToMin(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }
        (arr[maxPosition], arr[i]) = (arr[i], arr[maxPosition]);
    }
}

// Метод сортирующий массив с выбором направления сортировки, по умолчанию сортирует от меньшего
void SortArray(int[] arr, bool direction = true)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int index = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            // Направление сортировки
            if (direction) {if (arr[j] < arr[index]) index = j;}
            else           {if (arr[j] > arr[index]) index = j;}
            
        }
        (arr[index], arr[i]) = (arr[i], arr[index]);
    }
}

for (int i = 0; i < 4; i++)
{
    int[] arr = FillArray(8);
    Console.WriteLine("Пример работы метода:");
    Console.Write("Не отсортирован   - ");
    PrintArray(arr);
    switch (i)
    {
        case 0:
            Console.Write("SortFromMinToMax  - ");
            SortFromMinToMax(arr);
            break;
        case 1:
            Console.Write("SortFromMaxToMin  - ");
            SortFromMaxToMin(arr);
            break;
        case 2:
            Console.Write("SortArray default - ");
            SortArray(arr);
            break;
        case 3:
            Console.Write("SortArray false   - ");
            SortArray(arr, false);
            break;
    }
    PrintArray(arr);
}
