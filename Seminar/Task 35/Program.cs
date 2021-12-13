// Написать программу замены элементов массива на противоположные

int[] Array = new int[5];

void FillArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(-15, 15);
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

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > 0)
    {
        Console.Write(-Array[i] + " ");
    }
    else if(Array[i] < 0)
        {
            Console.Write(-Array[i] + " ");
        }
}
