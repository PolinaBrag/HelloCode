// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.Write("Введите номер дня недели:");

int Dayofweek = int.Parse(Console.ReadLine());
    

  if (Dayofweek < 1 || Dayofweek > 7 )
    {
    Console.WriteLine("В неделе 7 дней");
    }
else
{
if (Dayofweek == 6 || Dayofweek == 7)
    {
     Console.WriteLine("День недели выходной");
    }
  
else
    {
    Console.WriteLine("День недели будний");
    }

}



