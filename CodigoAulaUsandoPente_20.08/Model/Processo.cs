using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgoritmoDeOrdenacao.Model;

//CLASSE PROCESSO - int id, Date data -> ordenar primeiro por id e depois data e depois tentar usando as duas chaves 
//1) COMO ORDENAR UMA LISTA POR ALGUMA CHAVE DO OBJETO
//2) COMO ORDENAR, POR EXEMPLO,POR DATA E ID NA 2º CHAVE
internal class Processo
{
    public int id;
    public DateTime data;

    public Processo(int id, DateTime data)
    {
        this.id = id;
        this.data = data;

    }
    public override bool Equals(object? obj)
    {
        return obj is Processo processo && id == processo.id;
    }



    override
    public string ToString()
    {
        return "ID: " + id + " Data: " + data.ToString("dd/MM/yyyy"); 
    }

    


}
