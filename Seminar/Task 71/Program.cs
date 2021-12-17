// Найти сумму цифр числа

int number = 100
;
int sum = 0;

int sumOfDigits(int num)
{
    if (num < 10)
    {
        return num;
    }
    else
    {
        sum = sumOfDigits(num/10);
        sum = sum + num %10;
        return sum;
    }
}

Console.WriteLine(sumOfDigits(number));