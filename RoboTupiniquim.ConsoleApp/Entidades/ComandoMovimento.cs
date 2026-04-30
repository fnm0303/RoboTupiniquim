using System;

namespace RoboTupiniquim.ConsoleApp.Entidades;

public class ComandoMovimento
{
    public static void Movimentar(char instrucao, string orientacao, ref int posicaoInicialEixoX, ref int posicaoInicialEixoY)
    {
        if (instrucao == 'M' && orientacao == "N")
        {
            posicaoInicialEixoY = posicaoInicialEixoY + 1;
        }
        else if (instrucao == 'M' && orientacao == "S")
        {
            posicaoInicialEixoY = posicaoInicialEixoY - 1;
        }
        else if (instrucao == 'M' && orientacao == "L")
        {
            posicaoInicialEixoX = posicaoInicialEixoX + 1;
        }
        else if (instrucao == 'M' && orientacao == "O")
        {
            posicaoInicialEixoX = posicaoInicialEixoX - 1;
        }

    }
}
