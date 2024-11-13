using System;

public class Exercicio_9
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Determinar os limites máximos do plano cartesiano
        int maxX = 1001; // Ajustado para garantir que os índices estejam dentro do limite
        int maxY = 1001;

        // Matriz para representar o plano do mar
        bool[,] mar = new bool[maxX, maxY];

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split();
            int x1 = int.Parse(entrada[0]);
            int y1 = int.Parse(entrada[1]);
            int x2 = int.Parse(entrada[2]);
            int y2 = int.Parse(entrada[3]);

            // Marcar os pontos cobertos pelo retângulo (x1, y1) até (x2, y2)
            for (int x = x1; x < x2; x++)
            {
                for (int y = y1; y < y2; y++)
                {
                    mar[x, y] = true; // Marca o ponto como coberto
                }
            }
        }

        // Contar quantos pontos estão cobertos
        int areaCoberta = 0;
        for (int x = 0; x < maxX; x++)
        {
            for (int y = 0; y < maxY; y++)
            {
                if (mar[x, y])
                {
                    areaCoberta++;
                }
            }
        }

        Console.WriteLine(areaCoberta);
    }
}
