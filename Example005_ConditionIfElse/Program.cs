Console.Write("Please, enter your name: ");
string username = Console.ReadLine()!;

if (username.ToLower() == "masha")
{
    Console.WriteLine("Wow, it's Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}