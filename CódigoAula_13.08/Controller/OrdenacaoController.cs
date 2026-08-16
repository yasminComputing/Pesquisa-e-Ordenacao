using System.Diagnostics;
using Model;
using View;

namespace Controller;

class OrdenacaoController
{
    public void Executar()
    {
        List<int> listaAgitacao = new List<int>();
        List<int> listaSort = new List<int>();
        List<int> listaBolha = new List<int>();
        List<int> listaSelecao = new List<int>();
        List<int> listaInsercao = new List<int>();


        Util.popular(listaBolha, 1000);
        Util.popular(listaAgitacao, 1000);
        Util.popular(listaSelecao, 1000);
        Util.popular(listaInsercao, 1000);
        Util.popular(listaSort, 1000);

        Stopwatch sw = Stopwatch.StartNew();
        OrdenacaoView view = new OrdenacaoView();

        sw.Start();

        Ordenacao.Bolha(listaBolha);

        sw.Stop();

        view.exibirTempo( sw,"Ordenacao por bolha");

        sw.Reset();



        sw.Start();

        Ordenacao.Agitacao(listaAgitacao);

        sw.Stop();

        view.exibirTempo(sw,"Ordenacao por agitacao");

        sw.Reset();

        sw.Start();

        Ordenacao.Selecao(listaSelecao);

        sw.Stop();

        view.exibirTempo(sw,"Ordenacao por selecao");

        sw.Reset();

        sw.Start();

        Ordenacao.Insercao(listaInsercao);

        sw.Stop();

        view.exibirTempo(sw,"Ordenacao por insercao"
        );

        sw.Reset();

        sw.Start();

        listaSort.Sort();

        sw.Stop();

        view.exibirTempo(sw,"Ordenacao por sort nativo");

        sw.Reset();


    }
}