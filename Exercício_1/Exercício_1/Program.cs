using System;

public class Program
{
    public static void Main()
    {

        int linha = 4;
        int coluna = 5;
        int[,] matriz = new int[linha, coluna];
        geraMatriz(matriz,linha, coluna);
        imprimeMatriz(matriz, linha, coluna);
        // Verificar se o menor valor possível da soma absoluta das colunas da matriz é menor que o maior valor possível do produto das linhas da matriz 
        int resultado = verificaCondicao(matriz, linha, coluna);
        if(resultado == 1){
            Console.WriteLine("\nCondição Satisfeita");
        }
        else{
            Console.WriteLine("\nCondição Não Satisfeita");
        }
    }

    static void geraMatriz(int[,] matriz, int linha, int coluna)
    {
        int min = 1;
        int max = 20;
        Random random = new Random();

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                //Número aleatórios entre 1 e 20. Max + 1 pois vai até o máximo, parando em um valor anterior.
                matriz[i, j] = random.Next(min, max+1);
            }
        }
    }

    static void imprimeMatriz(int[,] matriz, int linha, int coluna)
    {
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static int verificaCondicao(int[,] matriz, int linha, int coluna)
    {

        // Encontrar o menor valor possível da soma absoluta das colunas
        int minSoma = int.MaxValue;
        for (int j = 0; j < coluna; j++)
        {
            int sum = 0;
            for (int i = 0; i < linha; i++)
            {
                sum += (matriz[i, j]);
            }
            // Verifica o menor valor entre 2 variáveis. Poderia também fazer um if e verificar se minSoma < sum e fazer a troca do valor de minSoma com a ajuda de uma variável auxiliar
            minSoma = Math.Min(minSoma, sum);
          
        }

        // Encontrar o maior valor possível do produto das linhas
        // Em C#, o valor mínimo para um inteiro é representado pela constante int.MinValue, que é igual a -2.147.483.648. Esse valor é o menor número inteiro que pode ser armazenado em uma variável do tipo int.
        // Usando minValue estamos definindo um valor inicial muito baixo, de modo que qualquer valor inteiro que for encontrado durante o for será maior do que esse valor
        int maxProduto = int.MinValue;
        for (int i = 0; i < linha; i++)
        {
            int auxProd = 1;
            for (int j = 0; j < coluna; j++)
            {
                auxProd *= matriz[i, j];
            }
            //Verifica o maior valor entre 2 variáveis
            maxProduto = Math.Max(maxProduto, auxProd);
        }

        Console.WriteLine("\nMenor valor possível da soma absoluta das colunas: " + minSoma);
        Console.WriteLine("Maior valor possível do produto das linhas: " + maxProduto);

        // Verificar se a condição é satisfeita
        if( minSoma <= maxProduto){
            return 1;
        }
        else{
            return 0;
        }
    }

   
}
