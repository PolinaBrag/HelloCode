// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] Array = new int [8];

void FillArray(int[] Arr)
{
    int length = Arr.Length;
    int i = 0;
    while (i < length)
    {
        Arr[i] = new Random().Next(0,2);
        i++;
    }

}

void PrintArray(int[] Arr2)
{
    int length = Arr2.Length;
    int i = 0;
    while (i < length)
    {
        Console.Write(Arr2[i] + " ");
        i++;
    }
}
FillArray(Array);
PrintArray(Array);
