using ProjetoMedicacaoEmC_.Model;
using System.Diagnostics;

namespace ProjetoMedicacaoEmC_.View;

internal class ListaView
{
    internal class ListaController
    {
        /**
        * método de classe que exibe conteúdo de uma lista de inteiros
        * @param lista
        * @param frase - para exibir no início do método
        */
        public void ExibirLista(List<int> lista, string frase)
        {
            Console.WriteLine(frase);
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine($"Total de registros: {lista.Count}");
        }
    }
}
