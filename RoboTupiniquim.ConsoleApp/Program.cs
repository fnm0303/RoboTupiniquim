//PROJETO ROBÔ TUPINIQUIM
namespace RoboTupiniquim.ConsoleApp;

using RoboTupiniquim.ConsoleApp.Entidades;
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
                orientacao = ComandoADireita.VirarADireita(instrucoes[i], orientacao);

            //verificando direção se instrução E
            else if (instrucoes[i] == 'E')
                orientacao = ComandoAEsquerda.VirarAEsquerda(instrucoes[i], orientacao);

            //verificando movimento
            else if (instrucoes[i] == 'M')
                ComandoMovimento.Movimentar(instrucoes[i], orientacao, ref posicaoInicialEixoX, ref posicaoInicialEixoY);
        }

        Console.WriteLine($"\nPosição Final: {posicaoInicialEixoX} {posicaoInicialEixoY} {orientacao}");
        Console.ReadLine();
    }
}
