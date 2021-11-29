// Найти третью цифру числа или сообщить, что её нет
int N = new Random().Next(1,999);
Console.WriteLine(N);
if (N > 99)
{
    Console.WriteLine($"Третья цифра числа: {N%10}");
}
else
{
Console.WriteLine($"В этом числе нет третьей цифры");
}