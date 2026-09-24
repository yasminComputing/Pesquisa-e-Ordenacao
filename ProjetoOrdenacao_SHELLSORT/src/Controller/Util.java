
package Controller;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;


public class Util {
    public static boolean carregarArquivo(String nomeArquivo,ArrayList<Integer> lista){
        try {
            FileReader procurador = new FileReader(nomeArquivo);
            BufferedReader leitor= new BufferedReader(procurador);
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
            return false; //para na interface aparecer o erro ao tentar ler o arquivo
        }
    }    
  }
    

