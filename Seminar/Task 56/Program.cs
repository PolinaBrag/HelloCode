// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] doubleArray = new int[4, 5];

void FillArray(int[,] newArray)
{
    for (int row = 0; row < newArray.GetLength(0); row++)
    {
        for (int column = 0; column < newArray.GetLength(1); column++)
        {
            newArray[row, column] = new Random().Next(1, 10);
            Console.Write(newArray[row, column] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(doubleArray);
Console.WriteLine();

double average = 0;

for (int column = 0; column < doubleArray.GetLength(1); column++)
    {
        double sum = 0;
        for (int row = 0; row < doubleArray.GetLength(0); row++)
        {
            sum = sum + doubleArray[row, column];
            average = sum / (row + 1);
        }
        Console.WriteLine($"Среднее арифметическое столбца {column + 1} равно {average}");
    }