// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int xb, int ya, int yb, int za, int zb)
{
    int dx = xa - xb;
    int dy = ya - yb;
    int dz = za - zb;
    double distance = Math.Round(Math.Sqrt(dx * dx + dy * dy + dz * dz), 2, MidpointRounding.ToZero);
    return distance;
}

Console.WriteLine($"Расстояние между точкой A[{x1},{y1},{z1}] и точкой B[{x2},{y2},{z2}] в 3D пространстве -> {Distance(x1, x2, y1, y2, z1, z2)}");
