import java.util.ArrayList;
import java.util.List;

public class Main {
public static void main(String[] args) {
    
    List<Integer> lista = new ArrayList<>();

    lista.add(50);
    lista.add(20);
    lista.add(25);
    lista.add(40);
    lista.add(10);
    lista.add(100);

    Numero n = new Numero();

   
   if (!n.ordenandoLista(lista)){
        System.out.println("A lista não está ordenada");
   }

}
   

}
