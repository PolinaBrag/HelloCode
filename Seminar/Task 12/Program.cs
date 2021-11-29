// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int N = new Random().Next(10,99);
Console.WriteLine(N);
int FirstNumber = N %100;
FirstNumber = (FirstNumber/10);

int SecondNumber = N %10;

if (FirstNumber > SecondNumber)
{
    Console.WriteLine(FirstNumber);
}
else
{
Console.WriteLine(SecondNumber);
}