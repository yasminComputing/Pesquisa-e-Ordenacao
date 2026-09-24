
package Model;

import java.util.ArrayList;


public class Model {
    public static ArrayList<Integer> lista;
    public static ArrayList<Integer> listaOriginal;
  
     public static void salvarListaOriginal() {
        listaOriginal = new ArrayList<>(lista);
    }
    public static void retornarListaOriginal(){
        lista = new ArrayList<>(listaOriginal);
    }
}
