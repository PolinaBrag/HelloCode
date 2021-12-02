// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координату Х не равную 0:");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y не равную 0:");
int Y = int.Parse(Console.ReadLine());


if (X > 0 && Y > 0)
{
    Console.WriteLine("Точки находятся в I четверти плоскости");
}
else
    {
        if (X < 0 && Y > 0)
        {
            Console.WriteLine("Точки находятся во II четверти плоскости");
        }
            else
           {
                 if (X < 0 && Y < 0)
                     {
                      Console.WriteLine("Точки находятся в III четверти плоскости");
                     }
                         else
                            {
                             if (X > 0 && Y < 0)
                              {
                                 Console.WriteLine("Точки находятся в IV четверти плоскости");
                              }
                                   else
                                    {
                                            Console.WriteLine("Х или У не могут быть равны нулю"); 
                                    }
                            }

            }
    }