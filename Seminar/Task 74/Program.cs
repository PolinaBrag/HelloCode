// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int numberFirst = 4;
int numberSecond = 7;
int count = 12;

int Fibonacci(int a, int b, int n)
{
if (n <= a) return a;
if (n <= b) return b;
else
{
   return Fibonacci(a, b, n - 1) + Fibonacci(a, b, n - 2);
}
}

for (int i = 1; i <= count; i++)
{
    Console.Write(Fibonacci(numberFirst, numberSecond, i) + " ");
}



// int count = 12;

// int Fibonacci(int n)
// {
// if (n <= 2)
// return 1;
// else
// {
//    return Fibonacci(n - 2) + Fibonacci(n - 1);
// }
// }

// for (int i = 1; i < count; i++)
// {
//     Console.Write(Fibonacci(i) + " ");
// }
