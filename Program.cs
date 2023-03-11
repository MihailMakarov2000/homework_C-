// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадрат чисел от 1 до N.
// 5 -> 1, 4, 9, 16,25.
// 2 -> 1, 4.

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число 1");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine("{0}^2 = {1}", i, i*i);
        Console.ReadKey(true);
    }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,10
// A (7,-5); B (1,-1) -> 7,21
int getInt(){
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки А и В: ");
Console.Write("Введите А_x: ");
int x1 = getInt();
Console.Write("Введите А_y: ");
int y1 = getInt();
Console.Write("Введите B_x: ");
int x2 = getInt();
Console.Write("Введите B_y: ");
int y2 = getInt();
int d = (int)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine(d);

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти")
int namber = Convert.ToInt32(Console.ReadLine());
if (namber == 1)
{
    Console.WriteLine("X > 0, Y > 0");
}
else if (namber == 2)
{
    Console.WriteLine("X < 0, Y > 0");
}
else if (namber == 3)
{
    Console.WriteLine("X < 0, Y < 0");
}
else if (namber == 4)
{
    Console.WriteLine("X > 0, Y < 0");
}
else
{
    Console.WriteLine("Не сушествует такой четверти");
}

// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки по оси X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки по оси Y");
int y = Convert.ToInt32(Console.ReadLine());


// && - и 
// || - или
if (x > 0 && y > 0)
{
    Console.WriteLine(1);
}
else if (x < 0 && y > 0 )
{
    Console.WriteLine(2);
}
else if (x < 0 && y < 0)
{
    Console.WriteLine(3);
}
else if (x > 0 && y < 0)
{
    Console.WriteLine(4)
}
else 
{
    Console.WriteLine("Невозможно определить координаты четверти");
}