// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double b1 = 5;
double k1 = 10;

double b2 = 13;
double k2 = 4;

//y = k1 * x + b1
//y = k2 * x + b2
// x = (b2 - b1)/(k1 - k2)

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Координаты точки пересечения двух прямых {x} {y}");