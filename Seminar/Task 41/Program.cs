// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[10];

void FillArray(double[] arrayFirst)
{
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        arrayFirst[i] = new Random().Next(-50 , 50);
    }
}

void PrintArray(double[] arraySecond)
{
    for (int i = 0; i < arraySecond.Length; i++)
    {
        Console.Write(arraySecond[i] + " ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);

double max = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Максимальное число {max}");

double min = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Минимальное число {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {max - min}");
