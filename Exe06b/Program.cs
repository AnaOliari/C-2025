﻿//Criar um vetor de valores inteiros
int[] vetor = new int[100];


Random r = new Random();

//Preencher o vetor com valores aleatórios
for (int i = 0; i < vetor.Length; i++)
{
    //Gerar um valor randômico
    vetor[i] = r.Next(1000);
}

//Imprimir o vetor com valores aletatórios
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

Array.Sort(vetor);

Console.WriteLine("\n");
//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}