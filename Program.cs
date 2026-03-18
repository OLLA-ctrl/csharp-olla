using System;

class Program
{
    static void Main(string[] args)
    {
        string nom = "olla";
        int age = 21;

        Console.WriteLine("Bonjour !");
        Console.WriteLine($"Je m'appelle {nom} et j'ai {age} ans.");

        string[] amis = { "kwizera", "Chahrazad", "ella" };

        Console.WriteLine("Mes amis :");
        Console.WriteLine(amis[0]);
        Console.WriteLine(amis[1]);
        Console.WriteLine(amis[2]);
    }
}