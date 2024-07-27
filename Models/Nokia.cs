namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //IMPLEMENTADO
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override string ToString()
        {
            return $"Nokia - Número: {Numero}, Modelo: {Modelo}, IMEI: {IMEI}, Memória: {Memoria}GB";
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //IMPLEMENTADO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}