Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.Write("Num2 большее число, Num1 меньшее число");
}
else
{
Console.Write("Num1 большее число, Num2 меньшее число");
}