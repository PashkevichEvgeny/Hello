int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 1;
int time;
int distanceFirstFriend = 0;
int distanceSecondFriend = distance;
double pix = 140.0;
int a, b;

Console.Clear();
Console.SetCursorPosition(1, 1);
Console.WriteLine("+");
Console.SetCursorPosition(Convert.ToInt32(pix), 1);
Console.WriteLine("+");

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        distance -= (firstFriendSpeed + secondFriendSpeed) * time;
        distanceSecondFriend -= secondFriendSpeed * time;
        distanceFirstFriend += firstFriendSpeed * time;
        friend = 2;
        if (count > 4)
        {
            a = Convert.ToInt32(pix * (distanceSecondFriend - 3000) / 10000);
            Console.SetCursorPosition(a * 3, 2);
            Console.WriteLine(count + 1);
        }
        else
        {
            a = Convert.ToInt32(pix * distanceSecondFriend / 10000);
            Console.SetCursorPosition(a, 1);
            Console.WriteLine(count + 1);
        }
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        distance -= (firstFriendSpeed + secondFriendSpeed) * time;
        distanceSecondFriend -= secondFriendSpeed * time;
        distanceFirstFriend += firstFriendSpeed * time;
        b = Convert.ToInt32(pix * distanceFirstFriend / 10000);
        if (count > 4)
        {
            Console.SetCursorPosition(b * 3, 2);
            Console.WriteLine(count + 1);
        }
        else
        {
            Console.SetCursorPosition(b, 1);
            Console.WriteLine(count + 1);
        }
        friend = 1;
    }
    count++;
}

Console.WriteLine($"Собака пробежала туда-сюда {count} раз");
