// Задать номер четверти, показать диапазоны для возможных координат
//x, y - возможные координаты точек

Console.WriteLine("Введите номер четверти: ");
int frame = int.Parse(Console.ReadLine());
if (frame == 1) Console.WriteLine("x >= 0, y >= 0");
if (frame == 2) Console.WriteLine("x <= 0, y >= 0");
if (frame == 3) Console.WriteLine("x <= 0, y <= 0");
if (frame == 4) Console.WriteLine("x >= 0, y <= 0");