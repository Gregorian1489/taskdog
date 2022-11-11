Console.WriteLine("Введите дистанцию (больше 10)");
int distance = Convert.ToInt32(Console.ReadLine());//Преобразовываем строчный тип в число и записываем в переменную
int speed1 = 1;
int speed2 = 2;
int dogspeed = 5;
int friend  = 2;
int time;
int count = 0;
int x = 0;  //Промежуточная пременная

Console.WriteLine("Исходные данные:");
Console.WriteLine($"Дистанция = {distance}");
Console.WriteLine($"Скорость первого друга = {speed1}, скорость второго друга = {speed2}");
Console.WriteLine($"Скорость собаки = {dogspeed}, пес бежит от {friend} - го друга");

while (distance>10)
{
    if (friend == 2)
    {
    time = distance/(speed1 + dogspeed);
    distance = distance - (speed1+speed2) * time;   
    }
    else
    {
    time = distance/(speed2 + dogspeed);
    distance = distance - (speed1+speed2) * time;
    }
    count++;
    if (count%2 == 0)
    {
        friend = 1;
    }
    else 
    {
        friend = 2;
    }
}
Console.WriteLine($"Собака пробежит {count} раз");