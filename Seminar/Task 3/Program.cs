Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Большее число: - {0}", num1);
    Console.WriteLine("Меньшее число: - {0}", num2);
}
else
{
Console.WriteLine("Большее число: - {0}", num2);
    Console.WriteLine("Меньшее число: - {0}", num1);
}