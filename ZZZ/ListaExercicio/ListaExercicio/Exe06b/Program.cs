

//Criar um vetor de valores inteiros
int[] vetor = new int[100];

//Gerar um valor randômico
Random r = new Random();

//Preencher o vetor com valores aleatórios
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(1000);
}

//Imprimir o vetor com valores aletatórios
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

//Ordenar o vetor com o Bubble Sort

Array.Sort(vetor);

Console.WriteLine("\n");
//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}