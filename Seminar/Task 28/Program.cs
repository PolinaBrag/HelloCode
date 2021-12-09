// Определить количество цифр в числе

double Num = new Random().Next(1, 10000);
Console.WriteLine($"Our number is {Num}");
int count = 0;

while (Num > 10)
{
Num = Num/10;
count++;
}
Console.WriteLine($"Amount of digits is {count+1}");