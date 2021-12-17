// Показать натуральные числа от N до 1, N задано
int n = 20;

string numbers(int number)
{
    if (number == 1)
    {
        return "" + number;
    }
    else
    {
        return number + " " + numbers(number - 1);
    }
}

Console.WriteLine(numbers(n));