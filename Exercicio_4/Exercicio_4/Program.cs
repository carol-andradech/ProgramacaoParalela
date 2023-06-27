using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int tam = 30;
        int[] vetor = new int[tam];
        GerarVetorAleatorio(vetor, tam); //Chamada para gerar função de gerar Vetor aleatório
        int[] vetorOrganizado = Organizar(vetor); //Chamada para organizar o vetor da forma desejada

        Console.WriteLine("\n Vetor Original:");
        ImprimirVetor(vetor, 30); //Chamada para impressão passando o vetor original

        Console.WriteLine("\n Vetor organizado em ordem não-crescente:");
        ImprimirVetor(vetorOrganizado, 30); //Chamada para impressão passando o vetor organizado em ordem decrescente
    }

    static int[] GerarVetorAleatorio(int[] vetor, int tam)
    {
        Random random = new Random();

        for (int i = 0; i < tam; i++)
        {
            vetor[i] = i + 1; // Distribui os números de 1 a 30
        }

        // Embaralha o vetor
        for (int i = 0; i < tam - 1; i++)
        {
            int j = random.Next(i, tam); // j recebe pelo método random.Next valor de no min i no máximo tam
            int aux = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = aux;
        }

        return vetor;
    }

    static int[] Organizar(int[] vetor)
    {
        int[] organizarVetor = vetor.ToArray(); //Transforma em array
        Array.Sort(organizarVetor); // Utiliza o método de array para organizar em ordem crescente
        Array.Reverse(organizarVetor); // Utiliza o método de array para reverter a ordem dos elementos
        return organizarVetor;
    }

    static void ImprimirVetor(int[] vetor, int tam)
    {
        for (int i = 0; i < tam; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }
}