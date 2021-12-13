// Определить, присутствует ли в заданном массиве, некоторое число

int[] Array = new int[20];

void FillArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(0, 100);
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

Console.WriteLine("Введите число для проверки присутствия в массиве:");
int Num = int.Parse(Console.ReadLine());

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] == Num)
    {
        Console.WriteLine($"Число {Num} присутствует в массиве");
        return;
    }
}
Console.WriteLine($"Число {Num} не присутствует в массиве");
