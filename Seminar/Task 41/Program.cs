// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[10];

void FillArray(double[] arrayFirst)
{
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        arrayFirst[i] = new Random().NextDouble() + new Random().Next(-50, 50);
        Console.Write(arrayFirst[i] + " ");
    }
    Console.WriteLine();
}

FillArray(array);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }

}
Console.WriteLine($"Максимальное число {max}");
Console.WriteLine($"Минимальное число {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {max - min}");