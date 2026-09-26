namespace AtividadePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculos =
        [
            new Carro("carro rapido 123", 2026),
            new Moto("honda civic jeep ", 199),
            new Caminhao("caminhao lendario ", 4286)
        ];
        foreach (var veiculo in veiculos)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
        }
    }
}