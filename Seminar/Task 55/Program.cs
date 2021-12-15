﻿// В матрице чисел найти сумму элементов главной диагонали

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

int sumOfMainDiag = 0;
for (int row = 0; row < doubleArray.GetLength(0); row++)
    {
        for (int column = 0; column < doubleArray.GetLength(1); column++)
        {
            if (row == column)
            {
            sumOfMainDiag = sumOfMainDiag + doubleArray[row, column];
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма главной диагонали равна: {sumOfMainDiag}");