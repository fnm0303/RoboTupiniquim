//PROJETO ROBÔ TUPINIQUIM

//1. Inicializar posições iniciais e orientação
//Console.Clear();
Console.Write("Digite a posição inicial do robô no eixo X: ");
int posicaoInicialEixoX = Convert.ToInt32(Console.ReadLine());

Console.Write("\nDigite a posição inicial do robô no eixo Y: ");
int posicaoInicialEixoY = Convert.ToInt32(Console.ReadLine());

Console.Write("\nDigite a orientação inicial (N, S, L ou O): ");
string? orientacao = Console.ReadLine()?.ToUpper();

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
    if (instrucoes[i] == 'D' && orientacao == "N")
    {
        orientacao = "O";
    }
    else if (instrucoes[i] == 'D' && orientacao == "S")
    {
        orientacao = "L";
    }
    else if (instrucoes[i] == 'D' && orientacao == "O")
    {
        orientacao = "S";
    }
    else if (instrucoes[i] == 'D' && orientacao == "L")
    {
        orientacao = "N";
    }

    //verificando direção se instrução E
    if (instrucoes[i] == 'E' && orientacao == "N")
    {
        orientacao = "L";
    }
    else if (instrucoes[i] == 'E' && orientacao == "S")
    {
        orientacao = "O";
    }
    else if (instrucoes[i] == 'E' && orientacao == "O")
    {
        orientacao = "N";
    }
    else if (instrucoes[i] == 'E' && orientacao == "L")
    {
        orientacao = "S";
    }

    //verificando movimento
    if (instrucoes[i] == 'M' && orientacao == "N")
    {
        posicaoInicialEixoY = posicaoInicialEixoY + 1;
    }
    else if (instrucoes[i] == 'M' && orientacao == "S")
    {
        posicaoInicialEixoY = posicaoInicialEixoY - 1;
    }
    else if (instrucoes[i] == 'M' && orientacao == "O")
    {
        posicaoInicialEixoX = posicaoInicialEixoX + 1;
    }
    else if (instrucoes[i] == 'M' && orientacao == "L")
    {
        posicaoInicialEixoX = posicaoInicialEixoX - 1;
    }

}

Console.WriteLine($"\nPosição Final: {posicaoInicialEixoX} {posicaoInicialEixoY} {orientacao}");
Console.ReadLine();


