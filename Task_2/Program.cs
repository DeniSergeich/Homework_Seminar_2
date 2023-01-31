Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
int lenght = number.Length;
if (lenght < 3)
{
    Console.WriteLine("Третьей цифры нет!");
    return;
}
char num = number[2];
Console.WriteLine($"Третья цифра: {num}");