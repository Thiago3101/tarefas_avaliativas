public class Matematica
{
    public double Somar(double x, double y)
    {
        return x + y;
    }
    public double Maior(double x, double y)
    {
        if(x > y)
        {
            return x;
        }
        else if (x == y)
        {
            return y;
        }
        else
        {
            return y;
        }
        
    }
    public double Raiz(double x)
    {
        return Math.Sqrt(x);
    }
}