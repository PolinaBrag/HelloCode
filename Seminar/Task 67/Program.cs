// Показать натуральные числа от 1 до N, N задано

int n = 20;

string numbers(int n)
{
    if (n == 1)
    {
        return "" + n;
    }
    else
    {
        return numbers(n - 1) + " " + n;
    }
}

Console.WriteLine(numbers(n));