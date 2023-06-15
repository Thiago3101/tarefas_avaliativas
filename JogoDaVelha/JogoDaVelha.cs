using System.Globalization;
using System.Net.NetworkInformation;

public class JogoDaVelha
{

    private string[,] grade = new string[3, 3];

    public string vazia = " ";
    public string jogador1 = "X";
    public string jogador2 = "O";

    public JogoDaVelha()
    {
        for(int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++)
            {
                grade[i, j] = vazia;
            }
        }
    }

    public string[,] GetGrade()
    {
        return grade;
    }

    public void ExibirGrade()
    {

        Console.WriteLine($"      0   1   2 ");
        Console.WriteLine($"0 - | {grade[0, 0]} | {grade[0, 1]} | {grade[0, 2]} |");
        Console.WriteLine($"1 - | {grade[1, 0]} | {grade[1, 1]} | {grade[1, 2]} |");
        Console.WriteLine($"2 - | {grade[2, 0]} | {grade[2, 1]} | {grade[2, 2]} |");
    }

    public int Jogar(int linha, int coluna, int cont)
    {
        if(cont % 2 == 0)
        {
            if (grade[linha, coluna] != vazia)
            {
                Console.WriteLine("Posição já ocupada.");
                cont--;
                Console.ReadKey();
            }
            else grade[linha, coluna] = jogador1;
        }

        else if (cont % 2 != 0)
        {
            if (grade[linha, coluna] != vazia)
            {
                Console.WriteLine("Posição já ocupada.");
                cont--;
                Console.ReadKey();
            }
            else grade[linha, coluna] = jogador2;
        }
        return cont;
    }


    public bool Verifica()
    {

        if ((grade[2, 0] == jogador1 && grade[2, 1] == jogador1 && grade[2, 2] == jogador1) ||
            (grade[2, 0] == jogador2 && grade[2, 1] == jogador2 && grade[2, 2] == jogador2)) { return true; }

        if ((grade[1, 0] == jogador1 && grade[1, 1] == jogador1 && grade[1, 2] == jogador1) ||
            (grade[1, 0] == jogador2 && grade[1, 1] == jogador2 && grade[1, 2] == jogador2)) { return true; }

        if ((grade[0, 0] == jogador1 && grade[0, 1] == jogador1 && grade[0, 2] == jogador1) ||
            (grade[0, 0] == jogador2 && grade[0, 1] == jogador2 && grade[0, 2] == jogador2)) { return true; }

        //-------------------------------------------------------------------------------------------------------

        if ((grade[0, 0] == jogador1 && grade[1, 0] == jogador1 && grade[2, 0] == jogador1) ||
            (grade[0, 0] == jogador2 && grade[1, 0] == jogador2 && grade[2, 0] == jogador2)) { return true; }

        if ((grade[0, 1] == jogador1 && grade[1, 1] == jogador1 && grade[2, 1] == jogador1) ||
            (grade[0, 1] == jogador2 && grade[1, 1] == jogador2 && grade[2, 1] == jogador2)) { return true; }

        if ((grade[0, 2] == jogador1 && grade[1, 2] == jogador1 && grade[2, 2] == jogador1) ||
            (grade[0, 2] == jogador2 && grade[1, 2] == jogador2 && grade[2, 2] == jogador2)) { return true; }

        //-------------------------------------------------------------------------------------------------------

        if ((grade[0, 0] == jogador1 && grade[1, 1] == jogador1 && grade[2, 2] == jogador1) ||
            (grade[0, 0] == jogador2 && grade[1, 1] == jogador2 && grade[2, 2] == jogador2)) { return true; }

        if ((grade[0, 2] == jogador1 && grade[1, 1] == jogador1 && grade[2, 0] == jogador1) ||
            (grade[0, 2] == jogador2 && grade[1, 1] == jogador2 && grade[2, 0] == jogador2)) { return true; }

        else
        {
            int vz = 0;
            for (int i = 0; i < grade.GetLength(0); i++)
            {
                for (int j = 0; j < grade.GetLength(1); j++)
                {
                    if (grade[i, j] == vazia)
                    {
                        vz++;
                    }
                }
            }
            if (vz == 0) return true;
        }
        return false;
    }
}