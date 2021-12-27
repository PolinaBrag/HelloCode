﻿// Написать программу возведения числа А в целую стень B

int number = 3;
int pow = -8;

double numberPow(int a, int b)
{
    if (b < 0)
        return numberPow(a, b + 1) / a;
    if (b == 0)
        return 1;
    else
        return numberPow(a, b - 1) * a;
}
Console.WriteLine(numberPow(number, pow));


// int numberPow (int a, int b)
// {
//     if (b == 1)
//     return a;
//     else if (b%2 == 0)
//     return numberPow(a*a, b/2);
//     else
//     {
//         return numberPow(a, b - 1) * a;
//     }
// }
// Console.WriteLine(numberPow(number, pow));