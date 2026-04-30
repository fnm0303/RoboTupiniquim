using System;

namespace RoboTupiniquim.ConsoleApp.Entidades;

public class ComandoAEsquerda
{
    public static string VirarAEsquerda(char instrucao, string orientacao)
    {
        if (instrucao == 'E' && orientacao == "N")
        {
            orientacao = "O";
        }
        else if (instrucao == 'E' && orientacao == "S")
        {
            orientacao = "L";
        }
        else if (instrucao == 'E' && orientacao == "O")
        {
            orientacao = "S";
        }
        else if (instrucao == 'E' && orientacao == "L")
        {
            orientacao = "N";
        }
        return orientacao;
    }
}
