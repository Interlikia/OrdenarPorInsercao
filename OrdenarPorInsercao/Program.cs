using System;

namespace OrdenarPorInsercao
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int chave;
            int[] vetor = new int[10];
            Random numAle = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = numAle.Next(50);
            }

           
            for (int i = 1; i < vetor.Length; i++)
            {
                chave = vetor[i];
                j = i - 1;
                while((j >= 0) && (vetor[j] > chave))
                {
                    vetor[j + 1] = vetor[j];
                    j = j - 1;
                }
                vetor[j + 1] = chave;
            }

            Console.WriteLine("");

            foreach (var num in vetor)
            {
                Console.Write($"{num},");
            }

        }
    }
}
