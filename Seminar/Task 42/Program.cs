// Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine());

if ((a + b > c) && (b + c > a) && (a + c > b))
{
    Console.WriteLine("Числа являются сторонами треугольника");
}
else
{
     Console.WriteLine("Числа не являются сторонами треугольника");
}