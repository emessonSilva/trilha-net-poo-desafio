namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"(checked)
    public class Nokia : Smartphone {
    public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
    {
        
    }
    
    public override void InstalarAplicativo (string nomeApp)
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"(checked)
        Console.WriteLine($"Instalando o {nomeApp} no Nokia.");
    }
  }
}
