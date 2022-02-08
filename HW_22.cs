// Найти расстояние между точками в пространстве 2D/3D
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

int x1 = new Random().Next(0, 10);
int y1 = new Random().Next(0, 10);
int z1 = new Random().Next(0, 10);
Console.WriteLine($"Координаты первой точки: {x1}, {y1}, {z1}");

int x2 = new Random().Next(0, 10);
int y2 = new Random().Next(0, 10);
int z2 = new Random().Next(0, 10);
Console.WriteLine($"Координаты второй точки: {x2}, {y2}, {z2}");

int X = Math.Abs(x2 - x1);
Console.WriteLine(X);
int Y = Math.Abs(y2 - y1);
Console.WriteLine(Y);
int Z = Math.Abs(z2 - z1);
Console.WriteLine(Z);

Console.WriteLine($"Расстояние между этими точками: {Math.Sqrt(X * X + Y * Y + Z * Z)}");


