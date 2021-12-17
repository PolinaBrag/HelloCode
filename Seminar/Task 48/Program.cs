// Написать программу копирования массива

// Console.WriteLine("Введите количество элементов массива в виде числа:");
// int count = int.Parse(Console.ReadLine());

// int[] array = new int [count];

// Console.WriteLine("Ваш массив:");

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1,100);
//         Console.Write(arr[i] + " ");
//     }
// Console.WriteLine();
// }

// FillArray(array);

// int[] newArray = new int[count];

// Console.WriteLine();
// Console.WriteLine("Копия массива:");

// void CopyArray(int[] arr2)
// {
//     for (int i = 0; i < arr2.Length; i++)
//     {
//        arr2[i] = array[i];
//        Console.Write(arr2[i] + " ");
//     }
// }

// CopyArray(newArray);

int[] array = {1,1, 4, 5, 5};

for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " ");
    }

Console.WriteLine();

string copy = string.Empty;
for (int i = 0; i < array.Length; i++)
    {
       copy = copy + array[i] + " ";
    }

Console.WriteLine(copy + " ");



int[] newArray = new int[5];

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
