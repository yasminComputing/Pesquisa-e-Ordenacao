using ProjetoMedicacaoEmC_.Controller;
using ProjetoMedicacaoEmC_.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMedicacaoEmC_;

internal class Principal
{
    static void Main(string[] args)
    {
        ListaController controller = new ListaController();
        controller.Executar();
    }

}
