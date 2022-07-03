using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Coeficiente A: ");
double a = double.Parse(Console.ReadLine()!, info);
Console.Write("Coeficiente B: ");
double b = double.Parse(Console.ReadLine()!, info);
Console.Write("Coeficiente C: ");
double c = double.Parse(Console.ReadLine()!, info);

double delta = Math.Pow(b, 2) - 4 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

if (delta < 0)
{
    Console.WriteLine("Está equação não possui raízes reais");
}
else
{
    Console.WriteLine($"X1 = {x1.ToString("F4", info)}");
    Console.WriteLine($"X2 = {x2.ToString("F4", info)}");
}
