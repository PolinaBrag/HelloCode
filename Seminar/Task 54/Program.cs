﻿// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

Console.WriteLine("Введите ваше число для проверки наличия в массиве:");
int num = int.Parse(Console.ReadLine());

//void CheckNumber(int[,] newArray)
//{
    for (int row = 0; row < doubleArray.GetLength(0); row++)
    {
        for (int column = 0; column < doubleArray.GetLength(1); column++)
        {
            if (num == doubleArray[row, column])
            Console.WriteLine($"Число присутствует в массиве на позиции [{row} , {column}]");
        }
    }
    Console.WriteLine($"Данного числа нет в массиве");
//}



//CheckNumber(doubleArray);
