int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int namber = Prompt ("Введите трехзначное число > ");
if (namber < 100 || namber >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуста повторите ввод");
    return;
}
Console.WriteLine ($"Введённое число `{namber}`");
int secondRank = namber / 10 % 10;
Console.WriteLine ($"Вторая цифра `{secondRank}`");