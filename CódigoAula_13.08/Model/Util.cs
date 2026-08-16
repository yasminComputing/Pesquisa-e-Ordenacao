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
}