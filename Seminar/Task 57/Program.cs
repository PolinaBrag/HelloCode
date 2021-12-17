// Написать программу, которая обменивает элементы первой строки и последней строки
int[,] doubleArray = new int[7, 5];

void FillArray(int[,] newArray)
{
    for (int row = 0; row < newArray.GetLength(0); row++)
    {
        for (int column = 0; column < newArray.GetLength(1); column++)
        {
            newArray[row, column] = new Random().Next(10, 99);
            Console.Write(newArray[row, column] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(doubleArray);

Console.WriteLine();

for (int row = 0; row < doubleArray.GetLength(0); row++)
{
    if (row == 0)
    {
        for (int column = 0; column < doubleArray.GetLength(1); column++)
        {
            int change = doubleArray[row, column];
            doubleArray[row, column] = doubleArray[doubleArray.GetLength(0) - 1, column];
            doubleArray[doubleArray.GetLength(0) - 1, column] = change;
            Console.Write(doubleArray[row, column] + " ");
        }
            Console.WriteLine();
    }
    else
    {
        for (int column = 0; column < doubleArray.GetLength(1); column++)
        {
            Console.Write(doubleArray[row, column] + " ");
        }
        Console.WriteLine();
    }
}


