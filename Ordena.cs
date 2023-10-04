using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge
{
    class Ordena
    {

        private static void intercala(List<int> lista, int ini, int meio, int fim)
        {
            int i = ini; //indice da porcao esquerda
            int j = meio +1; //indice da porcao direita
            List<int> listaTemporaria = new List<int>();
           
            while (i <= meio && j <= fim)
            {
                if (lista[i] <= lista[j])
                {
                    listaTemporaria.Add(lista[i]); //elemento da porcao esquerda vem para o temporario
                    ++i;
                }
                else
                {
                    listaTemporaria.Add(lista[j]); //elemento da porcao direita vem para o temporario
                    ++j;
                }
            }

            while (i <= meio)
            {
                listaTemporaria.Add(lista[i]);
                i++;
            }
            while(j <= fim)
            {
                
                 listaTemporaria.Add(lista[j]);
                 j++;
               
            }

            for (int k = 0; k < listaTemporaria.Count; k++)
            {
                lista[ini + k] = listaTemporaria[k];
            }

        }

        public static void mergeSort(List<int> lista, int ini, int fim)
        { //responsavel pela divisao = recursao
            int meio;
            if (ini < fim)
            {
                
                meio = (ini + fim) / 2;

                mergeSort(lista, ini, meio); //porcao da esquerda
                mergeSort(lista, meio + 1, fim); //porcao da direita                
                
                intercala(lista, ini, meio, fim);
            }
        }



    }
}