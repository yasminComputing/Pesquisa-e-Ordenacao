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


        int qtdComparacoes = 0;
        int qtdTrocas = 0;

        sw.Start();

        Ordenacao.Bolha(listaBolha, out qtdComparacoes, out qtdTrocas);

        sw.Stop();

        view.exibirTempo( sw,"Ordenacao por bolha");
        view.exibirQuantidade(qtdComparacoes,qtdTrocas);

        sw.Reset();



        sw.Start();

        Ordenacao.Agitacao(listaAgitacao,out qtdComparacoes,out qtdTrocas);

        sw.Stop();

        view.exibirTempo(sw,"Ordenacao por agitacao");
        view.exibirQuantidade(qtdComparacoes, qtdTrocas);


        sw.Reset();

        sw.Start();

        Ordenacao.Selecao(listaSelecao, out qtdComparacoes, out qtdTrocas);

        sw.Stop();

        view.exibirTempo(sw,"Ordenacao por selecao");
        view.exibirQuantidade(qtdComparacoes, qtdTrocas);


        sw.Reset();

        sw.Start();

        Ordenacao.Insercao(listaInsercao, out qtdComparacoes, out qtdTrocas);

        sw.Stop();

        view.exibirTempo(sw,"Ordenacao por insercao");
        view.exibirQuantidade(qtdComparacoes, qtdTrocas);


        sw.Reset();

        sw.Start();

        listaSort.Sort();

        sw.Stop();

        view.exibirTempo(sw,"Ordenacao por sort nativo");
       // view.exibirQuantidade(qtdComparacoes, qtdTrocas);


        sw.Reset();


    }
}