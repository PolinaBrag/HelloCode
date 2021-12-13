// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] Array = new int[123];

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

int count = 0;
int firstPoint = 10;
int secondPoint = 99;
for (int i = 0; i < Array.Length; i++)
{
    if((i >= (firstPoint - 1)) && (i <= (secondPoint - 1)))
    {
    count = count + 1;
    }
}
Console.WriteLine($"Количество элементов из отрезка [10,99] равно {count}");
