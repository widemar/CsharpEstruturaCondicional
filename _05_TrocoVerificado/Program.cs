using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Preço unitário do produto: ");
double precoUnitario = double.Parse(Console.ReadLine()!, info);
Console.Write("Quantidade comprada: ");
int quantidade = int.Parse(Console.ReadLine()!);
Console.Write("Dinheiro recebido: ");
double dinheiroRecebido = double.Parse(Console.ReadLine()!, info);

double valorDaCompra = precoUnitario * quantidade;

if (dinheiroRecebido < valorDaCompra)
{
    double dinheiroQueFalta = valorDaCompra - dinheiroRecebido;
    Console.WriteLine($"DINHEIRO INSUFICIENTE. FALTAM {dinheiroQueFalta.ToString("F2", info)} REAIS.");
}
else
{
    double troco = dinheiroRecebido - valorDaCompra;
    Console.WriteLine($"TROCO = {troco.ToString("F2", info)}");
}