using System;
class Program
{
    static void Main(string[] args)
    {
    inicio:;
        JogoDaVelha jogoDaVelha = new JogoDaVelha();
        int cont = 0;
        while (true)
        {
            Console.Clear();
            
            if (cont % 2 == 0 )
            {
                Console.WriteLine("Vez do jogador X");
            }
            else if(cont % 2 != 0 )
            {
                Console.WriteLine("Vez do jogador O");
            }

            
            jogoDaVelha.ExibirGrade();

            Console.Write("Digite a linha: ");
            int linha = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a coluna: ");
            int coluna = Convert.ToInt32(Console.ReadLine());


            cont = jogoDaVelha.Jogar(linha, coluna, cont);
            Console.Clear();
            jogoDaVelha.ExibirGrade();

            if (jogoDaVelha.Verifica())
            {
                Console.WriteLine("Fim de jogo");
                Console.ReadKey();
                goto inicio;
            }

            cont++;
        }
    }
}
