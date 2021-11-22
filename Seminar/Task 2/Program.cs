Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
if (num2 == num1* num1)
{
    Console.Write("Num2 это квадрат Num1");
}
else
{
Console.Write("Num2 это не квадрат Num1");
}