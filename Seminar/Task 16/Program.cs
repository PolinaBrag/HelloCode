// Дано число. Проверить кратно ли оно 7 и 23
int N = new Random().Next(1,999);
Console.WriteLine(N);
int FirstNumber = 7;
int SecondNumber = 23;
if (N%FirstNumber == 0 && N%SecondNumber == 0)
{
    Console.WriteLine($"Число {N} кратно числу {FirstNumber} и {SecondNumber}");
}
else
{
    Console.WriteLine($"Число {N} не кратно числу {FirstNumber} и {SecondNumber}");
}

