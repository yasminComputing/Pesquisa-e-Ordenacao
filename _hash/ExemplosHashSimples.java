import java.util.HashSet;

public class ExemplosHashSimples{
    public static void main(String[] args) {
        HashSet<String> tabelaHashString = new HashSet<>();

        tabelaHashString.add("alexandre");
        tabelaHashString.add("hermes");
        tabelaHashString.add("davi");
        tabelaHashString.add("alan");
        tabelaHashString.add("Alexandre");//vai aparecer no print por conta da diferença do maiusculo
        tabelaHashString.add("davi");

        for(String item : tabelaHashString){
            System.out.println(item + " -> " + item.hashCode());//item.hashCode para pegar o endereço
        }

        System.out.println(tabelaHashString.contains("alan") + "-> " + "alan".hashCode());
    }
}