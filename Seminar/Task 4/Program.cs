string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.Write("Введите номер дня недели:");

int Dayofweek = int.Parse(Console.ReadLine());

if (Dayofweek > 7 || Dayofweek < 1)
{
    Console.Write("Неверный номер дня недели");
}
else
{
Console.WriteLine(array [Dayofweek-1]);
}