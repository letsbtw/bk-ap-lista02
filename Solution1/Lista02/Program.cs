using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Lista02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
            //Exercicio06();

        }
        static void Exercicio01()
        {
            /*
             *  - Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, 
             *  em seguida, exiba esses elementos na tela.
             */

            int[] vetor = new int[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro: ");
                int num = Convert.ToInt32(Console.ReadLine());
                vetor[i] = num;
            }

            foreach (int num in vetor)
            {
                Console.WriteLine("Valor: " + num);
            }
        }


        static void Exercicio02()
        {
            /*
             * - Escreva um programa que declare e inicialize um vetor 
             * com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.
             */
            int[] vetor = new int[5];
            int maior = 0;
            int menor = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro: ");
                int num = Convert.ToInt32(Console.ReadLine());
                vetor[i] = num;
            }
            maior = vetor[0];
            menor = vetor[0];

            for (int i = 0; i <= vetor.Length; i++)
            {
                if (i < vetor.Length)
                {
                    if (vetor[i] > maior)
                    {
                        maior = vetor[i];
                    }
                    else if (vetor[i] < menor)
                    {
                        menor = vetor[i];
                    }
                }
            }
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Maior valor: " + maior);


        }

        static void Exercicio03()
        {
            /*
             * - Crie um programa que preencha uma matriz 3x3 
             * com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.
             */

            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.WriteLine("Digite um número inteiro: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    matriz[i, j] = num;
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void Exercicio04()
        {
            /*
             * - Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos 
             * elementos correspondentes de ambos os vetores, armazenando o resultado em um terceiro vetor. 
             * Em seguida, exiba o vetor resultante.
             */

            Console.WriteLine("Defina o tamanho dos dois vetores: ");
            int length = Convert.ToInt16(Console.ReadLine());

            int[] vetor1 = new int[length];
            int[] vetor2 = new int[length];
            int[] vetorResult = new int[length];


            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro para preencher o primeiro vetor: ");
                int num = Convert.ToInt32(Console.ReadLine());
                vetor1[i] = num;
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro para preencher o segundo vetor: ");
                int num = Convert.ToInt32(Console.ReadLine());
                vetor2[i] = num;
            }

            for (int i = 0; i < vetorResult.Length; i++)
            {
                vetorResult[i] = vetor1[i] + vetor2[i];
            }

            Console.WriteLine("Resultado: ");

            for (int i = 0; i < vetorResult.Length; i++)
            {
                Console.WriteLine(vetor1[i] + " + " + vetor2[i] + " = " + vetorResult[i]);
            }

        }

        static void Exercicio05()
        {
            /*
             * - Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.
             */

            int[,] matriz = new int[4, 4];
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }
            }


            int maior = matriz[0, 0];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("O maior número nessa matriz é: " + maior);

        }

        static void Exercicio06()
        {
            /*
             * - Busca de Dados em uma Matriz de Animais
  Suponha que você tenha uma matriz que representa uma lista de animais, 
  onde cada linha contém as seguintes propriedades de um animal:
    Nome
    Espécie
    Idade
    Peso
 Escreva um programa em C# que permita ao usuário buscar animais por uma determinada 
 propriedade (nome, espécie, idade ou peso) e exibir os animais que correspondem à busca.
   Matriz de animais [Nome, Espécie, Idade, Peso]
        string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
             */

            string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" } };

            string filtro = "";

            Console.WriteLine("Pesquisar: (por nome, espécie, idade ou peso)");
            filtro = Console.ReadLine();


            for (int i = 0; i < animais.GetLength(0); i++)
            {
                for (int j = 0; j < (animais.GetLongLength(0) - 1); j++)
                {
                    if (filtro == animais[i, j])
                    {
                        Console.WriteLine(animais[i, 0] + ", " + animais[i, 1] + ", " + animais[i, 2] + ", " + animais[i, 3]);
                    }
                }
            }





        }
    }
}

