﻿// Возведите число А в натуральную степень B используя цикл

int A = new Random().Next(1, 10);
Console.Write($"Число {A} возвести в степень ");
int B = new Random().Next(1, 10);
Console.WriteLine(B);
int result = 1;

for (int i = 1; i <= B; i++)
{
    result *= A;
}
Console.WriteLine(result);