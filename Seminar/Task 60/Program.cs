// В прямоугольной матрице найти строку с наименьшей суммой элементов.
int[,] doubleArray = new int[6, 20];

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


int minSum = 0;
for (int row = 0; row < 1; row++)
{
    for (int column = 0; column < doubleArray.GetLength(1); column++)
    {
        minSum = minSum + doubleArray[row, column];
    }
    //Console.WriteLine($"Cумма {row+1} строки равна {minSum}");
}

int sumOfRow = 0;
int numberOfRow = 1;
for (int row = 1; row < doubleArray.GetLength(0); row++)
{
    for (int column = 0; column < doubleArray.GetLength(1); column++)
    {
        sumOfRow = sumOfRow + doubleArray[row, column];
    }
    //Console.WriteLine($" Сумма {row + 1} сумма равна {sumOfRow}");
    if (sumOfRow < minSum)
    {
        int temp = sumOfRow;
        sumOfRow = minSum;
        minSum = temp;

        numberOfRow = row + 1;
    }
    sumOfRow = 0;

}
Console.WriteLine($"Строка {numberOfRow} с наименьшей суммой элементов, и ее сумма равна {minSum}");
