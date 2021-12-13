// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] Array = new int[12];

void FillArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(-10, 10);
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



void SumArrayPositiveNumber(int[] ArrThird)
{
    int Sum = 0;
    for (int i = 0; i < ArrThird.Length; i++)
    {

        if (ArrThird[i] > 0)
        {
            Sum = Sum + ArrThird[i];
        }

    }
    Console.WriteLine($"Сумма положительных элементов массива {Sum}");
}


void SumArrayNegativeNumber(int[] ArrFourth)
{
    int Sum = 0;
    for (int i = 0; i < ArrFourth.Length; i++)
    {

        if (ArrFourth[i] < 0)
        {
            Sum = Sum + ArrFourth[i];
        }

    }
    Console.WriteLine($"Сумма отрицательных элементов массива {Sum}");
}

FillArray(Array);
PrintArray(Array);
SumArrayPositiveNumber(Array);
SumArrayNegativeNumber(Array);
