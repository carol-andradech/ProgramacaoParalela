using System;

public class Program
{
   public static void Main(string[] args)
    {
        int tam = 5;
        int[] vetor = new int[tam];

        PreencheVetor(vetor, tam);

        Console.WriteLine("Vetor original:");
        ImprimeVetor(vetor, tam);

        OrganizaVetor(vetor, 0, tam-1);

        Console.WriteLine("Vetor organizado:");
        ImprimeVetor(vetor, tam);
    }

    static void PreencheVetor(int[] vetor, int tam)
    {
        Console.WriteLine("Digite 20 números naturais maiores que 1:");
        for (int i = 0; i < tam; i++)
        {
            //Converte o recebido string em int
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

    }

    static void OrganizaVetor(int[] vetor, int inicio, int fim)
    {
        // O primeiro if verifica o índice de início é maior ou igual ao índice de fim. Se for, significa que já percorremos todo o vetor e não há mais elementos a serem organizados. Então, a função retorna e sai da recursão.
        if (inicio >= fim)
        {
            return;
        }
        //verifica cada elemento chamando a função verificaComposto e mandando o vetor na posição de início atual
        int composto = verificaComposto(vetor[inicio]);
        
        //Caso não seja composto
        if (composto == 0)
        {
            // O número não é composto, então troca com o último número
            int aux = vetor[inicio];
            vetor[inicio] = vetor[fim];
            vetor[fim] = aux;
            //chama a proxima posição. Começamos no fim e vamos do fim ao começo verificando
            OrganizaVetor(vetor, inicio, fim - 1);
        }
        //se for composto, não faz alteração de posição e vai para o próximo início, vamos do começo ao fim
        else
        {
            OrganizaVetor(vetor, inicio + 1, fim);
        }
    }

    static int verificaComposto(int num)
    {
        if (num <= 1)
        {
            return 0; // Não é composto
        }

        //Um número composto deve ser maior que 1
        //Executamos um for que começa em 2 e vai até a raiz quadrada do número (Math.Sqrt(num)).
        //Pois para verificar seum número é composto, só precisamos verificar os divisores até a raiz quadrada dele.
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            //se for divisível
            if (num % i == 0)
            {
                return 1; // É composto
            }
        }

        return 0; // Não é composto
    }

    static void ImprimeVetor(int[] vetor, int tam)
    {
        for (int i = 0; i < tam; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}
