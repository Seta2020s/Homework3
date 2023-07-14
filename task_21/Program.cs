//Напишите программу,которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве


double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}

double GetInput(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetInput("Введите координату X первой точки: ");
double y1 = GetInput("Введите координату Y первой точки: ");
double z1 = GetInput("Введите координату Z первой точки: ");

double x2 = GetInput("Введите координату X второй точки: ");
double y2 = GetInput("Введите координату Y второй точки: ");
double z2 = GetInput("Введите координату Z второй точки: ");

double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние между двумя точками: {distance}");