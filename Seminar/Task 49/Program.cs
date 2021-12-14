// Показать двумерный массив размером m×n заполненный целыми числами
int[,] matrix = new int[3,3];

void FillAray(int[,] matrix2)
{
    for (int row = 0; row < matrix2.GetLength(0); row++)
    {
      for (int column = 0; column < matrix2.GetLength(1); column++)
      {
        matrix2[row, column] = new Random().Next(1,100);
        Console.Write(matrix2[row, column] + " ");
      }
      Console.WriteLine();
    }
}

FillAray(matrix);