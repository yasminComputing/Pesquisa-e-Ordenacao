using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMedicacaoEmC_.Model;

internal class Utilidades
{
    public static void PopularLista(List<int> lista,long quantidade, int inicio,int fim,Boolean aleatorio)
    {
        Random gerador = new Random();
        if (aleatorio)
        {
            for(long i = 0;i < quantidade; i++)
            {
                lista.Add(gerador.Next(inicio, fim + 1));
            }
        }
        if (!aleatorio)
        {
            for(long i = 0; i< quantidade; i++)
            {
                lista.Add(inicio + (int)i);
            }
        }
    }
}
