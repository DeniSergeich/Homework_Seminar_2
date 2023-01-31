Console.Clear();
Console.Write("Введите трехзачное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}
Console.WriteLine(number % 100 / 10);