//PROJETO ROBÔ TUPINIQUIM

class Program
{
    static void Main(string[] args)
    {
        //1. Inicializar posições iniciais e orientação
        //Console.Clear();
        Console.Write("Digite a posição inicial do robô no eixo X: ");
        int posicaoInicialEixoX = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nDigite a posição inicial do robô no eixo Y: ");
        int posicaoInicialEixoY = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nDigite a orientação inicial (N, S, L ou O): ");
        string orientacao = Console.ReadLine().ToUpper();

        Console.WriteLine($"\nPosição Inicial: {posicaoInicialEixoX} {posicaoInicialEixoY} {orientacao}");

        //2. Receber comando
        Console.Write("\nDigite uma sequência de instruções seguindo as regras: " +
        "\nE - virar robô para Esquerda." +
        "\nD - virar robô para Direita." +
        "\nM - mover (andar)." +
        "\nComando: ");
        string comando = Console.ReadLine().ToUpper();
        Console.WriteLine($"\nInstruções: {comando}");

        //3. Quebrar comando em instruções
        char[] instrucoes = comando.ToCharArray();

        //4. Verificar instrução
        for (int i = 0; i < instrucoes.Length; i++)
        {
            //verificando direção se instrução D
            if (instrucoes[i] == 'D')
                orientacao = ComandoADireita(instrucoes[i], orientacao);

            //verificando direção se instrução E
            else if (instrucoes[i] == 'E')
                orientacao = ComandoAEsquerda(instrucoes[i], orientacao);

            //verificando movimento
            else if (instrucoes[i] == 'M')
                ComandoMovimento(instrucoes[i], orientacao, ref posicaoInicialEixoX, ref posicaoInicialEixoY);
        }

        Console.WriteLine($"\nPosição Final: {posicaoInicialEixoX} {posicaoInicialEixoY} {orientacao}");
        Console.ReadLine();
    }

    static string ComandoADireita(char instrucao, string orientacao)
    {

        if (instrucao == 'D' && orientacao == "N")
        {
            orientacao = "L";
        }
        else if (instrucao == 'D' && orientacao == "S")
        {
            orientacao = "O";
        }
        else if (instrucao == 'D' && orientacao == "O")
        {
            orientacao = "N";
        }
        else if (instrucao == 'D' && orientacao == "L")
        {
            orientacao = "S";
        }

        return orientacao;
    }

    static string ComandoAEsquerda(char instrucao, string orientacao)
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

    static void ComandoMovimento(char instrucao, string orientacao, ref int posicaoInicialEixoX, ref int posicaoInicialEixoY)
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
