// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine());

if (daynumber >=1 && daynumber <=5)
{
    Console.WriteLine("Это будний день!");
}
 else
{
     Console.WriteLine("Это выходной день!");
}

