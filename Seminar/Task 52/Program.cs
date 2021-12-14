// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] matrix = new int[6,6];

void FillAray(int[,] matrix2)
{
    for (int row = 0; row < matrix2.GetLength(0); row++)
    {
      for (int column = 0; column < matrix2.GetLength(1); column++)
      {
        matrix2[row, column] = row + column;
        Console.Write(matrix2[row, column] + " ");
      }
      Console.WriteLine();
    }
}

FillAray(matrix);