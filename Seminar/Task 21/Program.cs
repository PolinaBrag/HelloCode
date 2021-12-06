// Задать номер четверти, показать диапазоны для возможных координат
string[] Quaters = {"First Quater is X > 0 Y > 0", "Second Quater is X < 0 Y > 0", "Third Quater is X < 0 Y < 0", "Forth Quater is X > 0 Y < 0"};
Console.WriteLine("Enter your quarter:");
int Quater = int.Parse(Console.ReadLine());

Console.Clear();

if (Quater > 0 && Quater <= 4)
{
   Console.WriteLine(Quaters[Quater - 1]);
}
 else
 {
      Console.WriteLine("There are only 4 quaters, enter valid number");
 }







