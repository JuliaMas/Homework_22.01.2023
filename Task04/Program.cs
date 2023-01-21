// Найти расстояние между точками в пространстве 2D/3D
// (x1.y1) - первая точка A, (x2,y2) - вторая точка B, (z1,z2) - третья точка C

Console.WriteLine("Выбирите 1 - если расстояние между точками на плоскости, 2 - если в пространстве ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{      
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
}    
if (number == 2)
{
    Console.WriteLine("Введите координаты точки x1: ");
    int x1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты точки y1: ");
    int y1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты точки z1: ");
    int z1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты точки x2: ");
    int x2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты точки y2: ");
    int y2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты точки z2: ");
    int z2 = int.Parse(Console.ReadLine());

    double ABC; // расстояние 
    
    ABC = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine("Расстояние между двумя точками на плоскости равно " + ABC);
}    
