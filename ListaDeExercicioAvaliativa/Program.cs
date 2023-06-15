using System;
class Program
{
    static void Main(string[] args)
    {
        Matematica calc = new Matematica();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Oque deseja fazer:\n1 - Somar.\n2 - Maior.\n3 - Raiz quadrada.");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite um numero: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite outro numero: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(calc.Somar(num1, num2));
                    break;

                case 2:
                    Console.Write("Digite um numero: ");
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite outro numero: ");
                    double num4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(calc.Maior(num3, num4));
                    break;

                case 3:
                    Console.Write("Digite um número para retirar a raiz quadrada: ");
                    double raiz = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(calc.Raiz(raiz));
                    break;

            }
            Console.ReadKey();
        }
    }
}