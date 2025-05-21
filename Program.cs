using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int n = LerQntd();
        int soma = NumeroValido(n);
        Console.WriteLine($"A soma dos n�meros pares � {soma}");
        Console.ReadKey();
        Console.Clear();
    }
    static int LerQntd()
    {
        while (true)
        {
            Console.Write("Digite quantas vezes voc� vai digitar os n�meros: ");
            if(int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                return n;
            }
            Console.WriteLine("Por favor, digite um valor v�lido para essa entrada inicial\n(Pressione qualquer tecla para limpar e continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
    static int NumeroValido(int n)
    {
        int soma = 0;
        for(int i = 0; i < n; )
        {
            Console.Write($"Digite um n�mero par inteiro {i+1}: ");
            if(!int.TryParse(Console.ReadLine(), out int x) || x % 2 != 0)
            {
                Console.WriteLine("Favor, redigitar um n�mero par inteiro\n(Pressione qualquer tecla para limpar e continuar)");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            soma += x;
            i++;
        }
        return soma;
    }
}
