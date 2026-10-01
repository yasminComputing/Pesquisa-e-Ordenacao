import java.util.ArrayList;

import javax.swing.JOptionPane;

public class Principal {
    public static void main(String[] args) {

        ArrayList<Integer> lista = new ArrayList<>();

        Util.carregarArquivoEmLista("numeros_aleatorios.txt", lista);

        long tempoInicio, tempoFim;

        tempoInicio = System.nanoTime();

        Ordenacao.pente(lista);

        tempoFim = System.nanoTime();

        System.out.println("Tempo (ms) ordenação pente: " + (tempoFim - tempoInicio) / 1000000.0);

        Util.exibirLista(lista);

        System.out.println("Total de elementos na lista: " + lista.size());

        int numeroPesquisa = Integer.parseInt(JOptionPane.showInputDialog( "Digite um número para pesquisar:"));

        tempoInicio = System.nanoTime();

        boolean resultadoBinaria =  Ordenacao.pesquisaBinaria(numeroPesquisa, lista);

        tempoFim = System.nanoTime();

        System.out.println("Tempo (ms) pesquisa binária: "+ (tempoFim - tempoInicio) / 1000000.0);

        JOptionPane.showMessageDialog( null,"Resultado:" + resultadoBinaria);

        System.exit(1);
    }
}
