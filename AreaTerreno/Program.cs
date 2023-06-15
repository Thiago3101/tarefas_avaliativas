using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a largura do terreno: ");
        double largura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o comprimento do terreno: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());

        Terreno terreno = new Terreno(largura, comprimento);

        double area = terreno.Area();
        Console.WriteLine($"Area do terreno = {area}");

        Console.Write("Digite o valor por m²: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        double valorTerreno = terreno.Valor(valor);
        Console.WriteLine($"Valor do terreno = {valorTerreno}");
    }
}