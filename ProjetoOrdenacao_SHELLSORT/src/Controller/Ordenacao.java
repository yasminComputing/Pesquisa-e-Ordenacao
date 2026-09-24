package Controller;
import java.util.ArrayList;

public class Ordenacao {
   
public static ArrayList bolha(ArrayList<Integer> lista) {
        ArrayList<Float> metricas = new ArrayList<>();
        long qtdeComparacoes = 0;
        long qtdeTrocas = 0;
        int aux;
        boolean houveTroca;
        int i;
        do {
            houveTroca = false;
            for (i = 0; i < lista.size() - 1; i++) {
                qtdeComparacoes++;
                if (lista.get(i) > lista.get(i + 1)) {
                    houveTroca = true;
                    aux = lista.get(i);
                    lista.set(i, lista.get(i + 1));
                    lista.set(i + 1, aux);
                    qtdeTrocas++;
                }
            }
        } while (houveTroca);
        metricas.add((float)qtdeComparacoes);
        metricas.add((float)qtdeTrocas);
        return metricas;
    }
 public static ArrayList selecao(ArrayList<Integer> lista) {
        ArrayList<Float> metricas = new ArrayList<>();
        long qtdeComparacoes = 0;
        long qtdeTrocas = 0;   
        int i, j, posMenor, aux;
        posMenor = 0;
        
        for (i = 0; i < lista.size(); i++) {
            posMenor = i;
            for (j = i+1; j < lista.size(); j++) {
                qtdeComparacoes++;
                if (lista.get(j) < lista.get(posMenor)) {
                    posMenor = j;
                }
            }
             if (posMenor != i) {
            aux = lista.get(i);
            lista.set(i, lista.get(posMenor));
            lista.set(posMenor, aux);
            qtdeTrocas++;
        }
       }
       
        metricas.add((float)qtdeComparacoes);
        metricas.add((float)qtdeTrocas);
        return metricas;
    }
   
public static ArrayList insercao(ArrayList<Integer> lista) {
        ArrayList<Float> metricas = new ArrayList<>();
        long qtdeComparacoes = 0;
        long qtdeTrocas = 0;  
        int i, j, aux;

        for (i = 1; i < lista.size(); i++) {
            aux = lista.get(i);
            for (j = i-1; j > 0 && aux < lista.get(j); j--,qtdeComparacoes++) {
                qtdeTrocas++;
                lista.set(j+1, lista.get(j));
            }
            lista.set(j+1, aux);
        }
        metricas.add((float)qtdeComparacoes);
        metricas.add((float)qtdeTrocas);
        return metricas;
    }
  
public static ArrayList pente(ArrayList<Integer> lista) {
        ArrayList<Float> metricas = new ArrayList<>();
        long qtdeComparacoes = 0;
        long qtdeTrocas = 0;
        int aux;
        boolean houveTroca;
        int i;
        int distancia = lista.size();
        do {
            distancia  =(int)(distancia / 1.3);
            if(distancia <= 0){
                distancia = 1;
            }
            houveTroca = false;
            for (i = 0; i + distancia < lista.size() - 1; i++) {
                qtdeComparacoes++;
                if (lista.get(i) > lista.get(i + distancia)) {
                    houveTroca = true;
                    aux = lista.get(i);
                    lista.set(i, lista.get(i + distancia));
                    lista.set(i + distancia, aux);
                    qtdeTrocas++;
                }
            }
        } while (distancia > 1 || houveTroca);
        metricas.add((float)qtdeComparacoes);
        metricas.add((float)qtdeTrocas);
        return metricas;
    }

    public static ArrayList<Float> shell(ArrayList<Integer> lista) {
        ArrayList<Float> metricas = new ArrayList<>();

        long qtdeComparacoes = 0;
        long qtdeTrocas = 0;

        int tmp;
        int i, j;
        int distancia = 1;
        int referenciaTamanho = 3;

        int n = lista.size();

        do {
            distancia = referenciaTamanho * distancia + 1;
        } while (distancia < n);

        do {
            distancia = (int) (distancia / referenciaTamanho);

            for (i = distancia; i < n; i++) {
                tmp = lista.get(i);

                for (j = i - distancia; j >= 0; j -= distancia) {
                    qtdeComparacoes++;

                    if (tmp < lista.get(j)) {
                        lista.set(j + distancia, lista.get(j));
                        qtdeTrocas++;
                    } else {
                        break;
                    }
                }

                lista.set(j + distancia, tmp);
                qtdeTrocas++;
            }

        } while (distancia > 1);

        metricas.add((float) qtdeComparacoes);
        metricas.add((float) qtdeTrocas);

        return metricas;
    }

  
}