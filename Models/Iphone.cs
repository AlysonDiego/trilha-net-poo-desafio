namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //IPLEMENTADO!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override string ToString()
        {
            return $"Iphone - Número: {Numero}, Modelo: {Modelo}, IMEI: {IMEI}, Memória: {Memoria}GB";
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
    // TODO: Sobrescrever o método "InstalarAplicativo"
    //IMPLEMENTADO!
}
