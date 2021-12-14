// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите десятичное число:");
int num = int.Parse(Console.ReadLine());

int answer = 0;
int count = 0;
//int[] binaryNumber = {};

while(num != 0)
{
answer = num %2;
//binaryNumber[count] = answer;
num = num/2;
count++;
Console.Write(answer);
}


// for (int i = binaryNumber.Length-1; i >= 0; i--)
// {
//     
//     Console.Write(binaryNumber[binaryNumber.Length - 1]);
// }


