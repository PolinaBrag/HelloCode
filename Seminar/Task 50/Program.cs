// Показать двумерный массив размером m×n заполненный вещественными числами
double[,] matrix = new double[5,4];

void FillAray(double [,] matrix2)
{
    for (int row = 0; row < matrix2.GetLength(0); row++)
    {
      for (int column = 0; column < matrix2.GetLength(1); column++)
      {
        matrix2[row, column] = new Random().Next(- 10,10) + new Random().NextDouble();
        Console.Write(matrix2[row, column] + " ");
      }
      Console.WriteLine();
    }
}

FillAray(matrix);