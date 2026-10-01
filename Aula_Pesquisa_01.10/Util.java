
import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;

public class Util {

    public static boolean carregarArquivoEmLista(String nomeArquivo, ArrayList<Integer> lista) {
        try {
            FileReader procurador;
            procurador = new FileReader(nomeArquivo);
            BufferedReader leitor = new BufferedReader(procurador);
            String linha;
            do {
                linha = leitor.readLine();
                if (linha != null) {
                    lista.add(Integer.parseInt(linha));
                }                
            } while (linha != null);
            leitor.close();
            return true;
        } catch (Exception e) {
            return false;
        }
    }
    public static void exibirLista(ArrayList<Integer> lista){
          for (int i = 0; i < lista.size(); i++) {
            System.out.println(lista.get(i));
        }
    }
}
