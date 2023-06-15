public class Terreno
{
    private double largura;
    private double comprimento;

    public Terreno(double largura, double comprimento)
    {
        this.largura = largura;
        this.comprimento = comprimento;
    }

    public double getLargura()
    {
        return this.largura;
    }
    public double getComprimento()
    {
        return this.comprimento;
    }

    public double Area()
    { 
        return largura * comprimento;
    }
    public double Valor(double valor)
    {
        return valor * Area();
    }
}