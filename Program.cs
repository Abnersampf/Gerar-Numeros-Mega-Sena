using System;

namespace MegaSena
{
    class Program
    {
        // qtd = quantidade de números aleatórios qur você quer gerar;
        // max = valor máximo que esses números podem ser;
        // min = valor mínimo que esses números podem ser.
        static int qtd = 6, max = 60, min = 1;
        static void Main(string[] args)
        {
            int aleatorio;
            int[] numeros = new int[qtd];
            Random random = new Random();

            // Gera os números aleatórios (sem que haja repetição entre eles);
            // OBS: Caso você queira números repetidos, retire o loop while.
            for (int c = 0; c < numeros.Length; c++)
            {
                aleatorio = random.Next(min, max + 1);
                while (contem(aleatorio, numeros))
                {
                    aleatorio = random.Next(min, max + 1);
                }
                numeros[c] = aleatorio;
            }

            // Ordena os números dentro do vetor em ordem crescente.
            ordenar(numeros);

            // Apresenta os números na tela
            foreach (int n in numeros)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
        // Função que verifica se o número já existe dentro do vetor.
        static bool contem(int n, int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == n)
                {
                    return true;
                }
            }
            return false;
        }
        // Função que ordena os elementos do vetor em ordem crescente.
        static void ordenar(int[] vetor)
        {
            int menor = max + 1;
            int pos = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i; j < vetor.Length; j++)
                {
                    if (vetor[j] < menor)
                    {
                        menor = vetor[j];
                        pos = j;
                    }
                }
                vetor[pos] = vetor[i];
                vetor[i] = menor;
                menor = max + 1;
            }
        }
    }
}
