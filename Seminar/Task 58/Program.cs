// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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


for (int row = 0; row < doubleArray.GetLength(0); row++)
{
    for (int column = 0; column < doubleArray.GetLength(1); column++)
    {
        for (int i = column + 1; i < doubleArray.GetLength(1); i++)
        {
            if (doubleArray[row, column] < doubleArray[row, i])
            {
                int temporary = doubleArray[row, column];
                doubleArray[row, column] = doubleArray[row, i];
                doubleArray[row, i] = temporary;
            }
        }
        Console.Write(doubleArray[row, column] + " ");
    }
    Console.WriteLine();
}