// Найти третью цифру числа или сообщить, что её нет
int N = new Random().Next(1,9999);
Console.WriteLine(N);
if (N > 99)
{
    if (N < 1000)
    {
    Console.WriteLine($"Третья цифра числа: {N%10}");
    }
    else
    {
        N = N/10;
        N = N%10;
        Console.WriteLine($"Третья цифра числа: {N}");
    }
}
else
{
Console.WriteLine($"В этом числе нет третьей цифры");
}