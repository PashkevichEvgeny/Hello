int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int time;

// Когда растояние становится меньше 10 считаем, что друзья встретились
// Растояние при встрече должно быть больше 0, иначе цикл станет бесконечным
while (distance > 10)  
{
    // Время, за которое собака добегает до противоположенного друга
    time = distance / (firstFriendSpeed + dogSpeed);
    // Растояние, которое собака пробегает за это время
    distance -= (firstFriendSpeed + secondFriendSpeed) * time;
    // Когда собака меняет направление, обмениваем скорости друзей
    (firstFriendSpeed, secondFriendSpeed) = (secondFriendSpeed, firstFriendSpeed);
    // Увеличиваем количество собачьих пробежек
    count++;
}

Console.WriteLine($"Собака пробежала туда-сюда {count} раз");
