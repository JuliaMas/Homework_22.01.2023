// Найти расстояние между точками в пространстве 2D/3D
// (x1.y1) - первая точка, (x2,y2) - вторая точка

Console.WriteLine("Введите координаты точки x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки y2: ");
int y2 = int.Parse(Console.ReadLine());
double AB; // расстояние 
AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Расстояние между двумя точками на плоскости равно " + AB);


