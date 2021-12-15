// Написать программу копирования массива

Console.WriteLine("Введите количество элементов массива в виде числа:");
int count = int.Parse(Console.ReadLine());

int[] array = new int [count];

Console.WriteLine("Ваш массив:");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
        Console.Write(arr[i] + " ");
    }
Console.WriteLine();
}

FillArray(array);

int[] newArray = new int[count];

Console.WriteLine();
Console.WriteLine("Копия массива:");

void CopyArray(int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
       arr2[i] = array[i];
       Console.Write(arr2[i] + " ");
    }
}

CopyArray(newArray);
