// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число:");
int Palindrom = int.Parse(Console.ReadLine());
int[] Array = new int [5];

for (int i = 0; i <= Array.Length; i++)
{
    Array[i] = Palindrom%10;
    Palindrom = Palindrom/10;
}
int j = 0;
while (j < 2)
{
    if(Array[j] != Array[4-j])
    {
        Console.WriteLine("Число не является палиндромом");
        return;
    }
    
       j++; 
    
    
}
Console.WriteLine("Число является палиндромом"); 