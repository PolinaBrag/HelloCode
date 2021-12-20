// Составить частотный словарь элементов двумерного массива

int[,] doubleArray = new int[3, 3];

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



    // int count = 0;
    // for (int row = 0; row < doubleArray.GetLength(0);row++)
    // {
    //     for (int column = 0; column < doubleArray.GetLength(1); column++)
    //     {
    //         for (int i = 0; i < doubleArray.GetLength(1); i++)
    //         {
    //            if (doubleArray[row, column] == doubleArray[row, i])
    //            {
    //              count++;
    //            } 
    //            Console.WriteLine($" {doubleArray[row, column]} встречается {count} раз"); 
    //         }
    //         }           
    //      count = 0; 
    // }

    int num = doubleArray[row, column];

    for (int i = 1; i < doubleArray.length; i++)
    {
        if (count > 0 && i == num)
        {
            выводим
        }
    }
    
