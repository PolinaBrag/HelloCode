// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] Array = new int[5];

void FillArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] ArrSecond)
{
    for (int i = 0; i < ArrSecond.Length; i++)
    {
        Console.Write(ArrSecond[i] + " ");
    }
    Console.WriteLine();
}

FillArray(Array);
PrintArray(Array);

int countPositive = 0;
int countNegative = 0;
for (int i = 0; i < Array.Length; i++)
{
    if(Array[i] %2 == 0)
    {
        countPositive = countPositive + 1;
    }
    else
    {
        countNegative = countNegative + 1;
    }
}
Console.WriteLine($"Количество четных чисел - {countPositive}");
Console.WriteLine($"Количество нечетных чисел - {countNegative}");