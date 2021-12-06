// Найти расстояние между точками в пространстве 2D/3D
// AB = √(xb - xa)2 + (yb - ya)2

// Console.Write("Введите координату Xa:");
// int Xa = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Ya:");
// int Ya = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Xb:");
// int Xb = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Yb:");
// int Yb = int.Parse(Console.ReadLine());

// double Distance2D = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
// Console.Write($"Расстояние между координатами - {Distance2D}");

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Console.Write("Введите координату Xa:");
int Xa = int.Parse(Console.ReadLine());
Console.Write("Введите координату Ya:");
int Ya = int.Parse(Console.ReadLine());
Console.Write("Введите координату Za:");
int Za = int.Parse(Console.ReadLine());
Console.Write("Введите координату Yb:");
int Xb = int.Parse(Console.ReadLine());
Console.Write("Введите координату Xb:");
int Yb = int.Parse(Console.ReadLine());
Console.Write("Введите координату Zb:");
int Zb = int.Parse(Console.ReadLine());

double Distance3D = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
Console.Write($"Расстояние между координатами - {Distance3D}");

