// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine("А является квадратом В");
}
if (numberB == numberA*numberA)
{
    Console.WriteLine("B является квадратом A");
}
else
{
    Console.WriteLine("одно число не является квадратом другого");
}
