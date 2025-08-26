using DesafioPOO.Models;

// IMPLEMENTADO
class Program
{
    static void Main()
    {
        // IMPLEMENTADO

        Smartphone nokia = new Nokia("188409", "Modelo 5", "1111111111", 20);
        Smartphone iphone = new Iphone("497309", "Modelo 11", "2222222222", 62);

        Console.WriteLine("\n--- Teste com Nokia ---");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine("\n--- Teste com iPhone ---");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}