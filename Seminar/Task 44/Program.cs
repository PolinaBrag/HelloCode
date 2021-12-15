// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите десятичное число:");
int num = int.Parse(Console.ReadLine());

int answer = 0;
int count = 0;
string binaryNumber = string.Empty;

while(num > 0)
{
answer = num %2;
binaryNumber = answer.ToString() + binaryNumber;
num = num/2;
count++;
}

Console.Write(binaryNumber);


