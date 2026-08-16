using System.Diagnostics;

namespace View;

class OrdenacaoView
{
    public void exibirTempo(Stopwatch sw, string frase)
    {
        Console.WriteLine($"{frase} (ms): {sw.ElapsedMilliseconds}");
    }

    public void exibir(List<int> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }
}