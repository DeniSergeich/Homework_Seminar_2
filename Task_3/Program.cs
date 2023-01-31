Console.Clear();
Console.Write("Введите день недели от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day < 1 || day > 7)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}
if (day == 6 || day == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}