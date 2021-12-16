// Написать программу масштабирования фигуры

// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.WriteLine("Введите координаты фигуры одной строкой:");
string coordinats = Console.ReadLine()
 .Replace("(","")
 .Replace(")","")
 .Replace(" , ",",")
 .Replace(", ",",");
 // Правильно ли убран возможный пробел?
//   .Replace(" , ",",")
//  .Replace(", ",",");

Console.WriteLine("Укажите коэффициент масштабирования k:");
int k = int.Parse(Console.ReadLine());

 var data = coordinats.Split(" ")
                    .Select(item => item.Split(","))
                    .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                    .Select(point => (point.x * k, point.y * k))
                    .ToArray();

Console.WriteLine("Координаты масштабированной фигуры:");
for (int i = 0; i < data.Length; i++)
{
    Console.Write(data[i] + " ");
}
 // Почему пробел в конечных координатах?
 // (0, 0) (4, 0) (4, 4) (0, 4) 