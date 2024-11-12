using System;
using Biblioteca;
    internal class Exercicio_7
    {

        static double[,] SomaMatriz(double[,] matriz1, double[,] matriz2, int linhas, int colunas)
        {
            double[,] resultado = new double[linhas, colunas];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return resultado;
        }
        static double[,] SubtraiMatriz(double[,] matriz1, double[,] matriz2, int linhas, int colunas)
        {
            double[,] resultado = new double[linhas, colunas];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    resultado[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }
            return resultado;
        }

        static void Constante(double[,] matriz, double constante, int linhas, int colunas)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] += constante;
                }
            }
        }
        static void Main()
        {
           
            Console.WriteLine("Digite o número de linhas e colunas primeira matriz:");
            int linhas1 = int.Parse(Console.ReadLine());
            int colunas1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o número de linhas e colunas segunda matriz:");
            int linhas2 = int.Parse(Console.ReadLine());
            int colunas2 = int.Parse(Console.ReadLine());

          
            double[,] matriz1 = new double[linhas1, colunas1];
            double[,] matriz2 = new double[linhas2, colunas2];


            Matrizes.gera(matriz1);
            Console.WriteLine("*** 1-Matriz ***");
            Matrizes.mostraf(matriz1);

            Matrizes.gera(matriz2);
            Console.WriteLine("*** 2-Matriz ***");
            Matrizes.mostraf(matriz2);

        Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("(a) Somar as duas matrizes");
            Console.WriteLine("(b) Subtrair a primeira matriz da segunda");
            Console.WriteLine("(c) Adicionar uma constante às duas matrizes");
            Console.WriteLine("(d) Imprimir as matrizes");
            char opcao = char.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 'a':
                    double[,] soma = SomaMatriz(matriz1, matriz2, linhas1, colunas1);
                    Console.WriteLine("Resultado da soma das matrizes:");
                    Matrizes.mostraf(soma);
                    break;
                case 'b':
                    double[,] subtracao = SubtraiMatriz(matriz2, matriz1, linhas1, colunas1);
                    Console.WriteLine("Resultado da subtração da primeira matriz da segunda:");
                    Matrizes.mostraf(subtracao);
                    break;
                case 'c':
                    Console.WriteLine("Digite o valor da constante:");
                    double constante = double.Parse(Console.ReadLine());
                    Constante(matriz1, constante, linhas1, colunas1);
                    Constante(matriz2, constante, linhas1, colunas1);
                    Console.WriteLine("Matriz 1 após adicionar a constante:");
                    Matrizes.mostraf(matriz1);
                    Console.WriteLine("Matriz 2 após adicionar a constante:");
                    Matrizes.mostraf(matriz2);
                    break;
                case 'd':
                    Console.WriteLine("Matriz 1:");
                    Matrizes.mostraf(matriz1);
                    Console.WriteLine("Matriz 2:");
                    Matrizes.mostraf(matriz2);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

    }

