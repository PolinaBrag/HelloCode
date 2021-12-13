// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] Array = new int[6];

void FillArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(1, 100);
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


int product = 0;
int LastNum = 1;
for (int i = 0; i < Array.Length/2; i++)
{
    product = Array[i]*Array[Array.Length - LastNum];
    Console.WriteLine($"Произведение {Array[i]} и {Array[Array.Length - LastNum]} равно {product}");
    LastNum = LastNum + 1;
}
