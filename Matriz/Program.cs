int qtdlinhas = 3, qtdcolunas = 3;

float[,] matriz1 = new float[qtdlinhas,qtdcolunas];

float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

//criacao da matriz 1

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz1[linha,coluna] = new Random().Next(0,10);
    }
}

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz1[linha, coluna] + " ");
    }
}
Console.ReadLine();

for (int linha = 0;linha < qtdlinhas; linha++) 
{
    Console.WriteLine();
    float resultado = 0;
    for (int coluna = 0;coluna < qtdcolunas; coluna++)
    {
        if(linha < qtdlinhas)
        {
            resultado += matriz1[linha, coluna];
            if (qtdcolunas - 1 == coluna)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}


Console.ReadLine();

for(int linha = 0; linha < qtdlinhas; linha++)
{
    float resultado = 0;
    for(int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        resultado += matriz1[coluna,linha];
    }

    Console.WriteLine(resultado);
}

float diag = 0;

for (int linha = 0; linha < qtdlinhas; linha++)
{
    diag += matriz1[linha, linha];    
}
Console.WriteLine(diag);
diag = 0;
int auxLinha = 0;
for (int coluna = qtdcolunas-1; coluna >= 0; coluna--)
{
    diag += matriz1[auxLinha, coluna];
    auxLinha++;
}
Console.WriteLine(diag);