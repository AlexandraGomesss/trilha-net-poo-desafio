namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public sealed class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) {}
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Baixando aplicação de \"{nomeApp}\" na loja da Nokia...");
            Console.WriteLine($"\"{nomeApp}\" instalado com sucesso no Nokia {Modelo}!");
        }
    }
}