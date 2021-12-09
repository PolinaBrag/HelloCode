// Подсчитать сумму цифр в числе

int Num = new Random().Next(1, 100000);
Console.WriteLine($"Our number is {Num}");

int Sum = 0;
int A = Num;

while (Num > 0)
{
    A = Num%10;
    Sum += A;
    Num = Num/10;
}
Console.WriteLine($"Sum of digits is {Sum}");
