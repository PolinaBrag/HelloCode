// Найти произведение двух матриц

Console.WriteLine("Введите количество строк первого массива:");
int rowFirst = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первого массива:");
int columnFirst = int.Parse(Console.ReadLine());

int[,] doubleArrayFirst = new int[rowFirst, columnFirst];

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

Console.WriteLine("Введите количество строк второго массива:");
int rowSecond = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второго массива:");
int columnSecond = int.Parse(Console.ReadLine());

int[,] doubleArraySecond = new int[rowSecond, columnSecond];

Console.WriteLine();
FillArray(doubleArrayFirst);
Console.WriteLine();
FillArray(doubleArraySecond);
Console.WriteLine();

int product = 1;
int sum = 0;

int[,] newArr = new int[rowFirst, columnSecond];

if (columnFirst == rowSecond)
{
    for (int row = 0; row < doubleArrayFirst.GetLength(0); row++)
    {
        for (int i = 0; i < doubleArraySecond.GetLength(1); i++)
        {
            for (int column = 0; column < doubleArrayFirst.GetLength(1); column++)
            {
                product = doubleArrayFirst[row, column] * doubleArraySecond[column, i];
                //Console.Write(product + " ");
                sum = sum + product;
                
            }  
            newArr[row, i] = sum;
        }
        sum = 0;
    }
}
else
{
    Console.WriteLine("Перемножить матрицы невозможно: количество столбцов первой матрицы не равно количеству строк второй матрицы");
}

Console.WriteLine("Наша матрица:");
 for (int m = 0; m < newArr.GetLength(0); m++)
            {
                for (int n = 0; n < newArr.GetLength(1); n++)
                {
                    Console.Write(newArr[m, n] + " ");
                }
                Console.WriteLine();
            }
