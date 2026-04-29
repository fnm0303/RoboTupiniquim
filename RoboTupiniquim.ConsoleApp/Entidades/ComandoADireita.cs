using System;

namespace RoboTupiniquim.ConsoleApp.Entidades;

public class ComandoADireita
{
    public static string VirarADireita(char instrucao, string orientacao)
    {

        if (instrucao == 'D' && orientacao == "N")
        {
            orientacao = "O";
        }
        else if (instrucao == 'D' && orientacao == "S")
        {
            orientacao = "L";
        }
        else if (instrucao == 'D' && orientacao == "O")
        {
            orientacao = "S";
        }
        else if (instrucao == 'D' && orientacao == "L")
        {
            orientacao = "N";
        }

        return orientacao;
    }
}
