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



int count = 0;
for (int row = 0; row < doubleArray.GetLength(0); row++)
{
    for (int column = 0; column < doubleArray.GetLength(1); column++)
    {
        for (int i = 0; i < doubleArray.GetLength(0); i++)
        {
            for (int k = 0; k < doubleArray.GetLength(1); k++)
            {
                if (doubleArray[row, column] == doubleArray[i, k])
                {
                    count++;    
                }
            }
        }
            Console.WriteLine($"Число {doubleArray[row, column]} встречается {count} раз(а)"); 
        count = 0;
    }
}


// int num = doubleArray[row, column];
// for (int j = 1; j <= 10; j++)
//                 {
//                     if (count > 0 && j == num)
//                     {
//                         Console.WriteLine($" {j} встречается {count} раз");
//                     }
//                 }



