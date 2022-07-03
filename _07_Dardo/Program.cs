using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.WriteLine("Digite as três distâncias: ");
double distanciaUm = double.Parse(Console.ReadLine()!, info);
double distanciaDois = double.Parse(Console.ReadLine()!, info);
double distanciaTres = double.Parse(Console.ReadLine()!, info);

double maiorDistancia = distanciaUm > distanciaDois && distanciaUm > distanciaTres
    ? distanciaUm
    : Math.Max(distanciaDois, distanciaTres);

Console.WriteLine($"MAIOR DISTÂNCIA = {maiorDistancia.ToString("F2", info)}");