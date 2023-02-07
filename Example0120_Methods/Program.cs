// Какие существуют виды методов

// Вид 1. Ничего не принимают и ничего не возвращают
//        Метод выводящий имя автора

void Method1()
{
    System.Console.WriteLine("Автор: Иванов И.И.");
}
// Вызов метода1
System.Console.Write("Пример работы Method1 -> ");
Method1();

// Вид 2. Принимают некие аргументы, но ничего не возвращают
//        Метод выводящий принятое сообщение
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Вызов метода2
Console.Write("Пример работы Method2 -> ");
Method2("Текст сообщения");
//        Метод принимающий несколько именованных аргументов и
//        выводящих сообщение указанное количество раз
void Method2_1(string msg, int amount)
{
    for (int i = 0; i < amount; i++) Console.Write(msg);
}
// Вызов метода2_1
Console.Write("Пример работы Method2_1 с двумя аргументами -> ");
Method2_1("Hello! ", 5);
Console.WriteLine();
Console.Write("Пример работы Method2_1 с указанием аргументов -> ");
Method2_1(amount: 3, msg: "Hello ");

// Вид 3. Ничего не принимают, но возвращают некие значения
//        Метод возвращающий текущий год
int Method3()
{
    return DateTime.Now.Year;
}
// Вызов метода3 и сохранение его ответа в переменную
int year = Method3();
Console.WriteLine();
Console.WriteLine("Пример работы Method3 -> " + year);

// Вид 4. Принимают некие аргументы и возвращают некие значения
//        Метод возвращающий сообщение n количество раз заданные в аргументах
string Method4(int count, string Text)
{
    // Объявление пустой строкой переменной
    string result = String.Empty;
    for (int i = 1; i < count; i++) result += Text + "-";
    result += Text;
    return result;
}
// Вызов метода4 и сохранение его ответа в переменную
string res = Method4(10, "z");
Console.Write("Пример работы Method4 -> ");
Console.WriteLine(res);
