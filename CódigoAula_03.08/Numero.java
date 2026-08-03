import java.util.List;

public class Numero {

    public boolean ordenandoLista(List<Integer> lista){
       for(int i = 0; i < lista.size() - 1; i++){
            if(lista.get(i) > lista.get(i + 1)){
                 return false;
                 
            }
           
       }
       return false;
    }

}
