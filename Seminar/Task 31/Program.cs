// Показать кубы чисел, заканчивающихся на четную цифру


int N = new Random().Next(1,100);
Console.WriteLine($"Our number is {N}");

for (int i = 1; i <= N; i++)
{
    if(i%2 == 0)
    {
        Console.WriteLine($"Куб числа {i} = {Math.Pow(i, 3)}");
    }
}