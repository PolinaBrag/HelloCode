// Найти сумму элементов от M до N, N и M заданы
int m = 5;
int n = 35;
int sum = 0;

int numbers(int a, int b)
{
    if (a == b)
    {
        return a;
    }
    else
    {
        sum = numbers(a + 1, b);
        sum = sum + a;
        return sum;
    }
}

Console.WriteLine(numbers(m, n));