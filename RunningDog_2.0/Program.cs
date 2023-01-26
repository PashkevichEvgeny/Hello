int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int time;

while (distance > 10)
{
    time = distance / (firstFriendSpeed + dogSpeed);
    distance -= (firstFriendSpeed + secondFriendSpeed) * time;
    (firstFriendSpeed, secondFriendSpeed) = (secondFriendSpeed, firstFriendSpeed);
    count++;
}

Console.WriteLine($"Собака пробежала туда-сюда {count} раз");
