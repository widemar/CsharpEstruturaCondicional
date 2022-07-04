using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Valor de X: ");
double x = double.Parse(Console.ReadLine()!, info);
Console.Write("Valor de Y: ");
double y = double.Parse(Console.ReadLine()!, info);

string mensagem;
if (x == 0 && y > 0)
{
    mensagem = "Eixo Y";
}
else if (y == 0 && x > 0)
{
    mensagem = "Eixo X";
}
else if (x == 0 && y == 0)
{
    mensagem = "Origem";
}
else if (x > 0 && y > 0)
{
    mensagem = "Q1";
}
else if (x < 0 && y > 0)
{
    mensagem = "Q2";
}
else if (x < 0 && y < 0)
{
    mensagem = "Q3";
}
else
{
    mensagem = "Q4";
}

Console.WriteLine(mensagem);