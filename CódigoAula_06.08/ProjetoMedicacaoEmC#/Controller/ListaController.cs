using System;
using System.Collections.Generic;
using System.Diagnostics;
using ProjetoMedicacaoEmC_.Model;
using ProjetoMedicacaoEmC_.View;

namespace ProjetoMedicacaoEmC_.Controller;

internal class ListaController
{
    private ListaView view;

    public ListaController()
    {
        view = new ListaView();
    }

    public void Executar()
    {
        Stopwatch sw = new Stopwatch();

        List<int> listaAleatoria = new List<int>();
        List<int> listaSequencial = new List<int>();

        sw.Start();
        // rotina 1
        Utilidades.PopularLista(listaAleatoria, 100000, 100, 100000, true);
        sw.Stop();
        Console.WriteLine("Fim da rotina 1 (ms): " + sw.ElapsedMilliseconds);
        sw.Reset();

        sw.Start();
        // rotina 2
        Utilidades.PopularLista(listaSequencial, 100000, 1, 100000, false);
        sw.Stop();
        Console.WriteLine("Fim da rotina 2 (ms): " + sw.ElapsedMilliseconds);
        sw.Reset();
    }
}
