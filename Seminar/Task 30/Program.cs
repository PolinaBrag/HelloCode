// Написать программу вычисления произведения чисел от 1 до N

int N = new Random().Next(1,10);
Console.WriteLine($"Our number is {N}");

double Product = 1;

for(int i = 1; i <= N; i++)
{
    Product = Product * i;
}
Console.WriteLine($"Product of number is {Product}");
