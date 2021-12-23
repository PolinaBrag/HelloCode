// Найти сумму цифр числа

int number = -365;

int sumOfDigits(int num)
{
    if (num < 0)
        return sumOfDigits(num * -1);
    if (num < 10)
    {
        return num;
    }
    return sumOfDigits(num / 10) + num % 10;
}

Console.WriteLine(sumOfDigits(number));