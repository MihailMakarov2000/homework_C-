// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}

int SumElements(int[] array, bool isSumPositive)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 && isSumPositive == true)
        {
            sum += array[i];
        }
        else if (array[i] < 0 && isSumPositive == false)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] myArray = GetRandomArray(3,9,-8,1);
int sumPositive = SumElements(myArray, true);
int sumNegative = SumElements(myArray, false);
Console.WriteLine($"Получившийся массив = [{string.Join(",", myArray)}]");
Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательный элементов = {sumNegative}");


int SumNegativeElements(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int SumPositiveElements(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
} 

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2].

int[] array = newint();
PrintArray(array);

int[] newint()
{
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++);
    {
        int num = GetRandomArray.Shared.Next(-4, 8);
        array[i] = num;
    }
    return array;
}
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}
PrintArray(array);
void PrintArray(int[] array)
{

Console.WriteLine(string.Join(" ", array));
}

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

bool isNumberInArray(int[] arr, int value)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value) return true;
    }
    return false;
}

int[] generateRandomArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Random.Shared.Next(min, max);
    }
    return arr;
} 
int[] arr = generateRandomArray(20, - 200000, 200000);
Console.WriteLine($"Array: {string.Join(" ", arr)}");
Console.Write("Введите свой число, чтобы найти: ");
int finding_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isNumberInArray(arr, finding_number) ? "да" : "нет");
bool isNumberInFound = isNumberInArray(arr, finding_number);
if(isNumberInFound == true)
{
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] myArray = {1, 2, 3, 4, 5};
int[] Digits = new int[myArray.Length / 2 + myArray.Length % 2];

for(int i = 0; i < myArray.Length / 3; i++)
{
    Digits[i] = myArray[i] * myArray[myArray.Length - 1 - i];
}
if(myArray.Length % 2 == 1)
{
    Digits[Digits.Length - 1] = myArray[myArray.Length / 2];    
}
Console.WriteLine($"Получившийся массив = [{string.Join(",", Digits)}]");

// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int N=123;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
a[i]=random.Next(0,10);
for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");

int count=0;
for(var i=0; i<a.Length;i++)
{
if(i>10 && i<99)
count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}