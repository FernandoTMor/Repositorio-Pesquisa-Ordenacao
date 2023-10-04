using Merge;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<int> listaMerge = new List<int>();

        Console.Write("Quantidade de números: ");
        int quantidadeNumeros = int.Parse(Console.ReadLine());

        Utilidades.popularLista(listaMerge, quantidadeNumeros);

        Console.WriteLine("Lista original:");
        Utilidades.exibirLista(listaMerge);

        Stopwatch sw = new Stopwatch();

        sw.Start();
        Ordena.mergeSort(listaMerge, 0, listaMerge.Count - 1);
        sw.Stop();

        Console.WriteLine("Lista ordenada:");
        Utilidades.exibirLista(listaMerge);

        Console.WriteLine("Tempo decorrido para ordenar a lista: " + sw.ElapsedMilliseconds + " milissegundos");
    }
}










