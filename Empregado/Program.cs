using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            inicio:;
            Console.Clear();
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a data de admissão do funcionário: ");
            DateTime dataDeAdimissao = Convert.ToDateTime(Console.ReadLine());

            Empregado empregado = new Empregado(nome, salario, dataDeAdimissao);

            Console.WriteLine("\nVocê deseja aumentar o salário deste funcionário\n1 - sim\n2 - não");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\nQuantos porcento deseja aumentar?");
                    double porcentagem = Convert.ToDouble(Console.ReadLine());
                    empregado.Aumento(porcentagem);
                    Console.WriteLine("Aumento realizado.");
                    Console.WriteLine($"Salário atual = {empregado.GetSalario().ToString("C2")}");
                    break;
                default:
                    goto continua;
            }
        continua:;
            Console.WriteLine($"\nSoma total dos sálarios: {Empregado.somaSalario.ToString("C2")}");

            Console.WriteLine("\nDeseja registrar um novo funcionário:\n1 - sim\n2 - não");
            int opc = Convert.ToInt32(Console.ReadLine());
            if (opc == 1)
            {
                goto inicio;
            }
            else if (opc > 1)
            {
                goto fim;
            }
        }
    fim:;
    }
}