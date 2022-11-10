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
    
    time = distance/(speed1 + dogspeed);
    distance = distance - (speed1+speed2) * time;
     
    x = speed1;        //сохраняем во вспомогательную переменную значение скорости первого друга
    speed1 = speed2;   // меняем переменные местами, т.к. согласно задаче в формулах меняются скорости друзей
    speed2 = x;        // от прохода к проходу
       
    count = count + 1;    
       
}
Console.WriteLine($"Собака пробежит {count} раз"); // из за округлений int считает кривовато