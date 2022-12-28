//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

Console.Clear();

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distance;
}

Console.WriteLine("Введите х1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите z1: ");
double z1 = double.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите х2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите y2: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите z2: ");
double z2 = double.Parse(Console.ReadLine()!);
Console.Clear();

double dis = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстоягие между точкой А({x1},{y1},{z1}) и точкой В({x2},{y2},{z2}) равно {dis}");