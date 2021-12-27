﻿// Написать программу вычисления функции Аккермана

int num1 = 3;
int num2 = 4;

int AccermanFuc(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0))
    {
        return AccermanFuc(m - 1, 1);
    }
    if ((m > 0) && (n > 0))
    {
        return AccermanFuc(m - 1, AccermanFuc(m, n - 1));
    }
    return 0;
}

Console.WriteLine(AccermanFuc(num1, num2));