// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int N = new Random().Next(1,100);
Console.WriteLine(N);
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
if (N%num == 0)
{
    Console.WriteLine($"Число {N} кратно числу {num}");
}
else
{
    Console.WriteLine($"Остаток от деления: {N%num}");
}