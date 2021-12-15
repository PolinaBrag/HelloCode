// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] doubleArray = new int[4, 5];

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

void ChangeArray(int[,] newArray)
{
    for (int row = 0; row < newArray.GetLength(0); row++)
    {
            for (int column = 0; column < newArray.GetLength(1); column++)
            {
                if (row % 2 == 0 && column % 2 == 0)
                {
                    newArray[row, column] = newArray[row, column] * newArray[row, column];
                }
                Console.Write(newArray[row, column] + " ");
            }
            Console.WriteLine();
    }
}


ChangeArray(doubleArray);