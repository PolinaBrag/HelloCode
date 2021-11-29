// Дано число. Проверить кратно ли оно 7 и 23
int N = new Random().Next(1,999);
Console.WriteLine(N);
int FirstNumber = 7;
int SecondNumber = 23;
if (N%FirstNumber == 0)
{
    Console.WriteLine($"Число {N} кратно числу {FirstNumber}");
}
else
{
    Console.WriteLine($"Число {N} не кратно числу {FirstNumber}");
}

if (N%SecondNumber == 0)
{
    Console.WriteLine($"Число {N} кратно числу {SecondNumber}");
}
else
{
    Console.WriteLine($"Число {N} не кратно числу {SecondNumber}");
}