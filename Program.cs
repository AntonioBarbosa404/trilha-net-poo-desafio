using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Nokia
        Nokia nokia = new Nokia("123456789", "Nokia", "3310");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Criando um objeto Iphone
        Iphone iphone = new Iphone("987654321", "Apple", "X");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
