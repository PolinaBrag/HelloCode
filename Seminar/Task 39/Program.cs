// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] Array = new int[10];

void FillArray(int[] Arr)
{
    int nextNum = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = nextNum + 1;
        nextNum = nextNum + 1;
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

int sum = 0;
for (int i = 0; i < Array.Length; i++)
{
    if(Array[i] %2 == 0)
    {
        sum = sum + Array[i];
    }
}
Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции равна {sum} ");