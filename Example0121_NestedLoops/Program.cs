// Вложенные циклы. Вывод таблицы умножения
Console.WriteLine("Вложенные циклы. Вывод таблицы умножения");
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        // Вывод последнего столбца
        if (j == 10)
        {
            // Вывод с отступами ("{номер группы, количество отступов от правого края} ", группа)
            Console.Write("{0,2} * {1,-3}= {2,-3}", j, i, i * j);
            // Вывод остальных столбцов
        }
        else
        {
            Console.Write("{0,1} * {1,-3}= {2,-2}   ", j, i, i * j);
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
// Замена символов в произвольном тексте
string story = "Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, string newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += newValue;
        else result += text[i];
    }
    return result;
}
// Пример работы метода для замены символов в тексте
Console.WriteLine("-v- Пример работы метода заменяющего символы в тексте -v-");
string newStory = Replace(story, 'к', "k" );
System.Console.WriteLine(newStory + "\n");
newStory = Replace(newStory, 'и', "u" );
System.Console.WriteLine(newStory);
