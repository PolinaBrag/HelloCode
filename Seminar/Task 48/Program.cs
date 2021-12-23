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
    }
}

FillArray(array);

void PrintArray(int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write(arr2[i] + " ");
    }
Console.WriteLine();
}
PrintArray(array);


int[] newArray = new int[count];


Console.WriteLine();
Console.WriteLine("Копия массива:");

void CopyArray(int[] arrCopy, int[] arrOrigin)
{
    for (int i = 0; i < arrCopy.Length; i++)
    {
       arrCopy[i] = arrOrigin[i];
    }
}


CopyArray(newArray, array);
PrintArray(newArray);


array[2] = 12;

Console.WriteLine();
PrintArray(array);
PrintArray(newArray);