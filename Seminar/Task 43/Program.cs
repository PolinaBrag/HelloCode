// Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Сколько чисел Вы хотите ввести:");
int countUser = int.Parse(Console.ReadLine());

int countOfNumbers = 0;

for (int i = 1; i <= countUser; i++)
{
    Console.Write($"Число {i}: ");
    int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    countOfNumbers++;

}
}
Console.WriteLine($"Количество введенных чисел больше нуля равно {countOfNumbers}");


// Console.WriteLine("Введите первое число:");
// int firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int thirdNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите четвертое число:");
// int fouthNumber = int.Parse(Console.ReadLine());

// int[] array = {firstNumber, secondNumber, thirdNumber, fouthNumber};

// int count = 0;

//         for (int j = 0; j < array.Length; j++)
//         {
//             if (array[j] > 0)
//             {
//             count ++;
//             }
//         }

//  Console.WriteLine($"Количество введенных чисел больше нуля равно {count}");