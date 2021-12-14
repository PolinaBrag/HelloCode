// Показать числа Фибоначчи

Console.WriteLine("Ввведите число, заканчивающее ряд Фибоначчи:");
int end = int.Parse(Console.ReadLine());

int firstNum = 1;
int secondNum = 1;
Console.Write(firstNum + " " + secondNum + " ");

for (int i = 1; i <= end; i++)
{
    int fibNum = firstNum + secondNum;
    Console.Write(fibNum + " ");
    firstNum = secondNum;
    secondNum = fibNum;
}