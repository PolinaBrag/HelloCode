// Удалить вторую цифру трёхзначного числа
int N = new Random().Next(100,999);
Console.WriteLine(N);
int FirstNumber = N/100;
int ThirdNumber = N%10;
Console.Write(FirstNumber);
Console.Write(ThirdNumber);