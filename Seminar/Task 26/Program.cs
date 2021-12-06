// Найти сумму чисел от 1 до А
Console.WriteLine("Введите ваше число:");
int j = int.Parse(Console.ReadLine());

int total = 0;

for (int i = 1; i <= j; i++)
{
    total = total + i;
}
Console.WriteLine($"Сумма чисел от 1 до {j} = {total}");
