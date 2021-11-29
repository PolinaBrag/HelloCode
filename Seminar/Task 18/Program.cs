// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

if (num2 == num1 * num1)
{
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
}
else
{
if (num1 == num2 * num2)
{
     Console.WriteLine($"Число {num1} является квадратом числа {num2}");
}
else
{
    Console.WriteLine($"Заданные числа не являются квадратом друг друга");
}
}
