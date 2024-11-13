using System;


   internal class Exercicio_8
    {
        public static void mostra(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            int cont = 1;

            for (int i = 0; i < linhas; i++)
            {
                Console.Write($"Região {cont}: ");
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($" {mat[i, j]} |");
                }
                cont++;
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[,] matrix = new int[5, 8];
            Random random = new Random();

            // Populando a matriz com 1 em uma posição aleatória
            matrix[random.Next(0, 5), random.Next(0, 8)] = 1;

            int n = 0;
            do
            {
                Console.WriteLine("Digite um número entre 2 e 500000:");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n > 500000);

            mostra(matrix);

            while (n > 0)
            {
                Console.WriteLine("Digite a posição x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a posição y:");
                int y = int.Parse(Console.ReadLine());

                if (x >= 0 && x < 5 && y >= 0 && y < 8) // Verificação para garantir que os índices estão dentro do limite
                {
                    if (matrix[x, y] == 1)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else
                {
                    Console.WriteLine("Posição fora dos limites da matriz.");
                }

                n--;
            }

            if (n == 0)
            {
                Console.WriteLine("0");
            }
        }
    }

