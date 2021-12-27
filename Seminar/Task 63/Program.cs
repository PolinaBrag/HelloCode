// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(Console.ReadLine());

int[,] doubleArray = new int[rows, columns];

void FillArray(int[,] newArray)
{
    for (int row = 0; row < newArray.GetLength(0); row++)
    {
        for (int column = 0; column < newArray.GetLength(1); column++)
        {
            newArray[row, column] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,] newArray2)
{
    for (int row = 0; row < newArray2.GetLength(0); row++)
    {
        for (int column = 0; column < newArray2.GetLength(1); column++)
        {
            Console.Write(newArray2[row, column] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(doubleArray);
Console.WriteLine("Наш массив:");
PrintArray(doubleArray);
Console.WriteLine();


int min = doubleArray[0,0];
int rowMin = 0;
int colMin = 0;

for (int row = 0; row < doubleArray.GetLength(0); row++)
{
    for (int column = 0; column < doubleArray.GetLength(1); column++)
    {
            if (doubleArray[row, column] < min)
            {
                min = doubleArray[row, column];
                rowMin = row;
                colMin = column;
            }
    }
}
//Console.Write(min + " " + rowMin + " " + colMin);
   Console.WriteLine();
   
for (int row = 0; row < doubleArray.GetLength(0); row++)
    {
        for (int column = 0; column < doubleArray.GetLength(1); column++)
        {
            if (row != rowMin && column != colMin)
            Console.Write(doubleArray[row, column] + " ");
        }
        Console.WriteLine();
    }
