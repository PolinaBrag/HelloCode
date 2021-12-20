// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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
            newArray[row, column] = new Random().Next(1, 10);
            Console.Write(newArray[row, column] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(doubleArray);
Console.WriteLine();

int[,] secondArray = new int[rows, columns];
if (rows == columns)
{
for (int row = 0; row < secondArray.GetLength(0); row++)
    {
        for (int column = 0; column < secondArray.GetLength(1); column++)
        {
            secondArray[row, column] =  doubleArray[column, row];
            Console.Write(secondArray[row, column] + " ");
        }    
        Console.WriteLine();
    }
}
else
{
Console.WriteLine("Матрица не квадратная, переворот не возможен");
}