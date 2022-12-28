//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

Console.Clear();

double getUser(string message)
{
    Console.WriteLine(message);
    double result = double.Parse(Console.ReadLine()!);
    return result;
}

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distance;
}

double x1 = getUser("Введите х1: ");
Console.Clear();
double y1 = getUser("Введите y1: ");
Console.Clear();
double z1 = getUser("Введите z1: ");
Console.Clear();
double x2 = getUser("Введите х2: ");
Console.Clear();
double y2 = getUser("Введите y2: ");
Console.Clear();
double z2 = getUser("Введите z2: ");
Console.Clear();

double dis = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстоягие между точкой А({x1},{y1},{z1}) и точкой В({x2},{y2},{z2}) равно {dis}");