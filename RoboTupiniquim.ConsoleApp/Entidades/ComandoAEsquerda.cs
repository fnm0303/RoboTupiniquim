using System;

namespace RoboTupiniquim.ConsoleApp.Entidades;

public class ComandoAEsquerda
{
    public static string VirarAEsquerda(char instrucao, string orientacao)
    {
        if (instrucao == 'E' && orientacao == "N")
        {
            orientacao = "L";
        }
        else if (instrucao == 'E' && orientacao == "S")
        {
            orientacao = "O";
        }
        else if (instrucao == 'E' && orientacao == "O")
        {
            orientacao = "N";
        }
        else if (instrucao == 'E' && orientacao == "L")
        {
            orientacao = "S";
        }
        return orientacao;
    }
}
