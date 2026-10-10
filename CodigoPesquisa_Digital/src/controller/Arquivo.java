package controller;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;


public class Arquivo {
    public static boolean carregarArquivo(String nomeArquivo,ArrayList<String> lista){
        try{
            FileReader procurador = new FileReader(nomeArquivo);
            BufferedReader leitor = new BufferedReader(procurador);
            String linha;
            do{
                linha = leitor.readLine();
                if(linha != null){
                    lista.add(linha);
                }
            }while(linha != null);
            return true;
        }catch(Exception e){
            return false;
        }
    }
    
}
