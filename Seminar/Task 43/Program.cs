// Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите первое число:");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int SecondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int ThirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертое число:");
int FouthNumber = int.Parse(Console.ReadLine());

int[] array = {FirstNumber, SecondNumber, ThirdNumber, FouthNumber};

int count = 0;

        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > 0)
            {
            count ++;
            }
        }

 Console.WriteLine($"Количество введенных чисел больше нуля равно {count}");