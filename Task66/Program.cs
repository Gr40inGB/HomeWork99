
int count = 0; // количество подбеганий собаки
int toFriend = 2;   // направление движения собаки - по умолчанию  - от первого друга к второму = 2
                    // по умолчанию от второго друга к первому = 1

Console.WriteLine("Привет. Щас мы узнаем сколько раз собачка подбежит от одного друга к другому");
Console.Write("Введите расстояние между друзьями: ");
string str_distance = Console.ReadLine()!;
double distance = double.Parse(str_distance);

Console.Write("Введите скорость первого друга:  ");
string str_first_friend_speed = Console.ReadLine()!;
double first_friend_speed = double.Parse(str_first_friend_speed);

Console.Write("Введите скорость второго друга: ");
string str_second_friend_speed = Console.ReadLine()!;
double second_friend_speed = double.Parse(str_second_friend_speed);

Console.Write("Введите скорость Собаки: ");
string str_dog_speed = Console.ReadLine()!;
double dog_speed = double.Parse(str_dog_speed);



while (dog_speed < first_friend_speed || dog_speed < second_friend_speed)
{
   Console.Write("Скорость собаки должна быть выше, чем скорость друзей. Скорость первого друга  " + first_friend_speed + ", скорость второго " + second_friend_speed + ". Введите скорость Собаки:  ");
   str_dog_speed = Console.ReadLine()!;
   dog_speed = double.Parse(str_dog_speed);
}


while (distance > 10)
{
   if (toFriend == 1)

   {
      distance = distance - (first_friend_speed + second_friend_speed) * (distance / (first_friend_speed + dog_speed)); //  time = (distance / (first_friend_speed + dog_speed))
      count++;
      Console.WriteLine("гаф-гаф!  Я бежала " + string.Format("{0:f2}", (distance / (first_friend_speed + dog_speed))) + " времени. Расстояние между вами  " + string.Format("{0:f2}", distance));
      toFriend = 2;
   }
   else //// if (toFriend == 1)
   {
      distance = distance - (first_friend_speed + second_friend_speed) * (distance / (second_friend_speed + dog_speed)); //  time =(distance / (second_friend_speed + dog_speed)))
      count++;
      Console.WriteLine("тяф-тяф!  Я бежала " + string.Format("{0:f2}", (distance / (second_friend_speed + dog_speed))) + " времени. Расстояние между вами  " + string.Format("{0:f2}", distance));
      toFriend = 1;
   }
}

Console.WriteLine("Наконец-то! Я пробежала " + (count) + " раз");