// Показать натуральные числа от M до N, N и M заданы

int m = 5;
int n = 40;

void numbers(int a, int b)
{
    Console.Write(a + " ");
    if (a == b)
    {
        return;
    }
    else
    {
        numbers(a + 1, b);
    }
}

numbers(m, n);