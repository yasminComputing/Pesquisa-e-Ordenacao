using AlgoritmoDeOrdenacao.Model;
using System.ComponentModel;
using System.Diagnostics;

namespace Model;

class Util
{
    public static void popular(List<int> lista, int quantidade)
    {
        Random gerador = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            lista.Add(gerador.Next(100));
        }
    }

    public static void exibir(List<int> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public static void popularListProcesso(List<Processo> lista, int qtde)
    {
        Random gerador = new Random();
        for(int i = 0; i <qtde; i++)
        {
            int id = gerador.Next(1,10);
            DateTime data = DateTime.Now.AddDays(-gerador.Next(1, 100));
            lista.Add(new Processo(id, data));
        }


        
    }
}