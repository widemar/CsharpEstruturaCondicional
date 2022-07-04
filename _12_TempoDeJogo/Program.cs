Console.Write("Hora Inicial: ");
int horaInicial = int.Parse(Console.ReadLine()!);
Console.Write("Hora Final: ");
int horaFinal = int.Parse(Console.ReadLine()!);

int duracao;
if (horaInicial > horaFinal)
{
    duracao = 24 - (horaInicial - horaFinal);
}
else if (horaFinal > horaInicial)
{
    duracao = horaFinal - horaInicial;
}
else
{
    duracao = 24 - horaInicial - horaFinal;
}

Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");