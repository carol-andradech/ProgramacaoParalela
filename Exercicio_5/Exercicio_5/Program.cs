using System;

public class Program
{
    public static void Main()
    {

        int a;
        int b;

        //Ler o valor de a e continuar pedindo o valor caso a seja 0
        Console.Write("Digite o valor de a, sendo a diferente de 0: ");
        do
        {
            //Converte o recebido string em int
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.Write("O valor de a não pode ser zero, digite outro valor: ");
            }

        } while (a == 0);

        //Ler o valor de b e continuar pedindo o valor caso b seja menor que 0
        Console.Write("Digite o valor de b, sendo b maior que 0: ");
        do
        {
            //Converte o recebido string em int
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 0)
            {
                Console.Write("O valor de b deve ser maior que 0, digite outro valor: ");
            }

        } while (b < 0);

        int resultado = Power(a, b);
        Console.WriteLine("O valor de " + a + " elevado a " + b + " é: " + resultado + ".");

    }

    /* Como funciona a chamada na função recursiva:
    Supondo a = 2 e b = 3
    primeira chamada: Power(2, 3)
    chamada recursiva 1: Power(2, 2)
    chamada recursiva 2: Power(2, 1)
    chamada base: Power(2, 0) returns 1
    chamada recursiva 1: Power(2, 1) returns 2 *1 = 2
    chamada recursiva 2: Power(2, 2) returns 2 * 2 = 4
    resultando e retornando: 1 * 2 * 4 = 8 */
  static int Power(int a, int b)
    {
        if (b == 0)
        {
            //O resultado de um número elevado a 0 é sempre 1
            return 1;
        }
        else
        {
            //chama o próximo loop da resursão até chegar a 0
            return a * Power(a, b - 1);
        }
    }
}