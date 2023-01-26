int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 1;
int time;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        distance -= (firstFriendSpeed + secondFriendSpeed) * time; 
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        distance -= (firstFriendSpeed + secondFriendSpeed) * time; 
        friend = 1;
    }
    count++;
}

Console.WriteLine($"Собака пробежала туда-сюда {count} раз");
