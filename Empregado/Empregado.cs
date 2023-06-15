public class Empregado
{
    private string nome;
    private double salario;
    private DateTime dataDeAdmissao;
    public static double somaSalario;

    public Empregado(string nome, double salario, DateTime dataDeAdmissao)
    {
        this.nome = nome;
        this.salario = salario;
        this.dataDeAdmissao = dataDeAdmissao;
        somaSalario += salario;
    }

    public void Aumento(double porcentagem)
    {
        double aumento = salario * (porcentagem / 100);
        salario += aumento;
        somaSalario += aumento;
    }

    //Gets
    public string GetNome()
    {
        return nome;
    }
    public double GetSalario()
    {
        return salario;
    }
    public DateTime GetDataDeAdmissao()
    {
        return dataDeAdmissao;
    }


    //Sets
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public void SetSalario(double salario)
    {
        this.salario = salario;
    }
    public void SetDataDeAdmissao(DateTime dataDeAdmissao)
    {
        this.dataDeAdmissao = dataDeAdmissao;
    }
}