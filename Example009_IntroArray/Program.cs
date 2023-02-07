int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (res < arg2) res = arg2;
    if (res < arg3) res = arg3;
    return res;
}
// Объявление целочисленного массива и заполнение его значениями 
// индексы      0   1   2   3   4   5   6   7   8
int[] array = { 18, 22, 33, 94, 52, 67, 77, 48, 59 };

// Обращение по индексу к значению в массиве
array[0] = 28;

// Вычисление максимального значения в массиве и
// сохранение его в переменную result 
int result = Max(
    Max(array[0], array[1], array[3]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);