using AlgoritmoDeOrdenacao.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Model;

class Ordenacao
{

    public static void Bolha(List<int> lista,out int qtdComparacoes,out int qtdTrocas)
    {
        bool houveTroca;
        int tmp;

        qtdComparacoes = 0;
        qtdTrocas = 0;

        do
        {
            houveTroca = false;

            for (int i = 0; i < lista.Count - 1; i++)
            {
                qtdComparacoes++;

                if (lista[i] > lista[i + 1])
                {
                    qtdTrocas++;
                    houveTroca = true;

                    tmp = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = tmp;
                }
            }

        } while (houveTroca);
    }

    public static void Agitacao(List<int> lista,out int qtdComparacoes,out int qtdTrocas)
    {
        bool houveTroca;
        int tmp;

        int ini = 0;
        int fim = lista.Count;

        qtdComparacoes = 0;
        qtdTrocas = 0;

        do
        {
            houveTroca = false;

            for (int i = ini; i < fim - 1; i++)
            {
                qtdComparacoes++;

                if (lista[i] > lista[i + 1])
                {
                    qtdTrocas++;
                    houveTroca = true;

                    tmp = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = tmp;
                }
            }

            if (!houveTroca)
            {
                break;
            }

            fim--;

            houveTroca = false;

            for (int i = fim; i >= ini + 1; i--)
            {
                qtdComparacoes++;

                if (lista[i] < lista[i - 1])
                {
                    qtdTrocas++;
                    houveTroca = true;

                    tmp = lista[i];
                    lista[i] = lista[i - 1];
                    lista[i - 1] = tmp;
                }
            }

            ini++;

        } while (houveTroca);
    }

    public static void Selecao(List<int> lista,out int qtdComparacoes,out int qtdTrocas)
    {
        int posMenor;
        int tmp;
        qtdComparacoes = 0;
        qtdTrocas = 0;

        for (int i = 0; i < lista.Count - 1; i++)
        {
            posMenor = i;

            for (int j = i + 1; j < lista.Count; j++)
            {
                qtdComparacoes++;

                if (lista[j] < lista[posMenor])
                {
                    posMenor = j;
                }
            }

            if (i != posMenor)
            {
                qtdTrocas++;

                tmp = lista[i];
                lista[i] = lista[posMenor];
                lista[posMenor] = tmp;
            }
        }
    }

    public static void Insercao(List<int> lista,out int qtdComparacoes , out int qtdTrocas)
    {
        int i;
        int j;
        int tmp;

         qtdComparacoes = 0;
         qtdTrocas = 0;

        for (i = 1; i < lista.Count; i++)
        {
            tmp = lista[i];

            for (j = i - 1; j >= 0; j--)
            {
                qtdComparacoes++;

                if (tmp < lista[j])
                {
                    lista[j + 1] = lista[j];

                    qtdTrocas++;
                }
                else
                {
                    break;
                }
            }

            lista[j + 1] = tmp;

            qtdTrocas++;
        }
    }

    public static void Pente(List<Processo> lista)
    {
        int dist = lista.Count;
        bool houveTroca;
        Processo tmp;

        do
        {
            dist = (int)(dist / 1.3);

            if (dist < 1)
            {
                dist = 1;
            }

            houveTroca = false;

            for (int i = 0; i + dist < lista.Count; i++)
            {
                if (lista[i].id > lista[i + dist].id || (lista[i].Equals(lista[i + dist]) && lista[i].data > lista[i + dist].data))
                {
                    houveTroca = true;

                    tmp = lista[i];
                    lista[i] = lista[i + dist];
                    lista[i + dist] = tmp;
                }
            }

        } while (dist > 1 || houveTroca);
    }
}