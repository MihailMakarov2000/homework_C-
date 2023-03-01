Console.WriteLine("Введите первое число: ");
int number_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number_B = Convert.ToInt32(Console.ReadLine());

if  (number_A > number_B)
{
      Console.WriteLine("Первое число " + number_A + " больше чем второе " + number_B);
}
else
{
        Console.WriteLine("Второе число " + number_B + " больше чем первое " + number_A);
}

Console.WriteLine("Введите 3 числа:");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = num_2;

if (number_2 > max)
{
    max = number_2;
}

if (number_3 > max)
{
    max = number_3;
}
Console.WriteLine("Наибольшее из введённых чисел -> " + max);

Console.WriteLine("Введите число:");
number = Convert.ToInt32(Console.ReadLine());

if  (number % 2 == 1)
{
     Console.WriteLine("Число " + number + " является: нечетным");
}
else
{
        Console.WriteLine("Число " + number + "является: четным");
}

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + number);
while  (i <= number)
{
            if  (i % 2 != 1)
            {
                  Console.Write(i + ", ");
                  
            }     
              i++;
}


           {
                Console.WriteLine("Нет чётных чисел!");
           }