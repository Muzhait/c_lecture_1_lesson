int count = 0;
double distance = 10000;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
int friend = 2;

while (distance > 10)
if (friend == 1)
{
    double time = distance / (firstFriendSpeed + dogSpeed);
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
    friend = 2;
}
if (friend == 2)
{
    double time = distance / (secondFriendSpeed / dogSpeed);
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
    friend = 1;
}
 
 else 
 {
 Console.WriteLine(count);
 }