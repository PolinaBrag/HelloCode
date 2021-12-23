// Найти сумму цифр числа

int number = 15;

int sumOfDigits(int num)
{
    if (num < 10)
    {
        return num;
    }
    else
    {
      
        return sumOfDigits(num/10) + num %10;
    }
}

Console.WriteLine(sumOfDigits(number));