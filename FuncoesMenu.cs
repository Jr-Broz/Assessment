using System;
using System.IO;
using System.Collections.Generic;
namespace Assessment{ 
public class FuncoesMenu : IFuncoes{
        protected String NomePokemon;
        protected double PesoPokemon;
        protected bool Eh_Pokemon_Shiny;
        protected int NivelPokemon;
        protected DateTime dataDaCaptura;
        protected String IdPokedex;     
        double variavelAuxiliarPeso;
        bool variavelAuxiliarShiny;

 FileStream arquivo = new FileStream("Arquivos_Pokedex.txt", FileMode.OpenOrCreate);

public static List<String> listagem = new List<String>();

    public void setNomePokemon(String nomePokemon){

        NomePokemon = nomePokemon;
   
}
    public string getNomePokemon(){

    return NomePokemon;
}

    public void setNivelPokemon(int nivelPokemon){

    NivelPokemon = nivelPokemon;

}

    public int getNivelPokemon(){

    return NivelPokemon;
}

    public void setEh_Pokemon_Shiny(bool eh_shiny){

    Eh_Pokemon_Shiny = eh_shiny;
}

    public bool getEh_Pokemon_Shiny(){

    return Eh_Pokemon_Shiny;
}

    public void setDataCaptura(DateTime data_Captura){

    dataDaCaptura = data_Captura;
}
    public DateTime getDataCaptura(){

     return dataDaCaptura;

}

    public void setIdPokedex(String Id_pokedex){

    IdPokedex =  Id_pokedex;
}

    public String getIdPokedex(){

    return IdPokedex;

}

    public void setPesoPokemon(double pesoPokemon){

    PesoPokemon = pesoPokemon;
}

    public double getPesoPokemon(){

    return PesoPokemon;
}
 public void SalvarEmTexto(){

 try { 

        Console.WriteLine("Escreva o nome do pokemon");
        setNomePokemon(Console.ReadLine()); 

        Console.WriteLine("Escreva o Peso do Pokemon");
        variavelAuxiliarPeso = Double.Parse(Console.ReadLine());
        setPesoPokemon(variavelAuxiliarPeso);

        Console.WriteLine("O pokemon E Shiny?");
        variavelAuxiliarShiny = Boolean.Parse(Console.ReadLine());	
        
        if(variavelAuxiliarShiny == true){

            setEh_Pokemon_Shiny(true);
        }
         else{

            setEh_Pokemon_Shiny(false);
        }

        Console.WriteLine("Qual o Nivel do pokemon");
        setNivelPokemon(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Qual a data da Captura");
        setDataCaptura(DateTime.Parse(Console.ReadLine()));

        String variavelAuxiliarId = Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-"));

        Console.WriteLine("Gerando ID Único do pokemon.."); 
        setIdPokedex(variavelAuxiliarId);
        
        Thread.Sleep(1200);
        Console.WriteLine("Conferindo informações..");
        Thread.Sleep(1500);
        Console.WriteLine("Escrevendo em um arquivo de texto.");
        Thread.Sleep(1300);
        Console.WriteLine("Sucesso na Operação, obrigado por utilizar.");

    StreamWriter arquivar = new StreamWriter(arquivo);

    listagem.Add(getNomePokemon());
    listagem.Add(getIdPokedex());

    String dataCapturaConvertida = Convert.ToString(dataDaCaptura);
    String nivelConvertido = Convert.ToString(getNivelPokemon());
    String AuxShinyConvertido = Convert.ToString(variavelAuxiliarShiny);
    String AuxPesoConvertido = Convert.ToString(variavelAuxiliarPeso);

        arquivar.WriteLine("Nome do Pokemon: " + getNomePokemon());
        arquivar.WriteLine("Nivel: " + getNivelPokemon());
        arquivar.WriteLine("Data de Captura: " + dataCapturaConvertida);
        arquivar.WriteLine("É Shiny: " +  variavelAuxiliarShiny);
        arquivar.WriteLine("Peso: " + AuxPesoConvertido);
        arquivar.WriteLine("ID: " + IdPokedex);

    arquivar.Close();
    arquivo.Close();
}
    catch{

    System.Console.WriteLine("Ocorreu um Erro ao Cadastrar O Pokemon na Pokedex.");
    }
}
    public void SalvarEmLista(){

        Console.WriteLine("Escreva o nome do pokemon");
        setNomePokemon(Console.ReadLine()); 

        Console.WriteLine("Escreva o Peso do Pokemon");
        variavelAuxiliarPeso = Double.Parse(Console.ReadLine());
        setPesoPokemon(variavelAuxiliarPeso);

        Console.WriteLine("O pokemon E Shiny?");
        variavelAuxiliarShiny = Boolean.Parse(Console.ReadLine());	
        
        if(variavelAuxiliarShiny == true){

            setEh_Pokemon_Shiny(true);
        }
         else{

            setEh_Pokemon_Shiny(false);
        }

        Console.WriteLine("Qual o Nivel do pokemon");
        setNivelPokemon(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Qual a data da Captura");
        setDataCaptura(DateTime.Parse(Console.ReadLine()));

        String variavelAuxiliarId = Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-"));

        Console.WriteLine("Gerando ID Único do pokemon.."); 
        setIdPokedex(variavelAuxiliarId);
        
        Thread.Sleep(1200);
        Console.WriteLine("Conferindo informações..");
        Thread.Sleep(1500);
        Console.WriteLine("Escrevendo em um arquivo de texto.");
        Thread.Sleep(1300);
        Console.WriteLine("Sucesso na Operação, obrigado por utilizar.");

    String dataCapturaConvertida = Convert.ToString(dataDaCaptura);
    String nivelConvertido = Convert.ToString(getNivelPokemon());
    String AuxShinyConvertido = Convert.ToString(variavelAuxiliarShiny);
    String AuxPesoConvertido = Convert.ToString(variavelAuxiliarPeso);

    listagem.Add(getNomePokemon());
    listagem.Add(getIdPokedex());
    listagem.Add(dataCapturaConvertida);
    listagem.Add(nivelConvertido);
    listagem.Add(AuxShinyConvertido);
    listagem.Add(AuxPesoConvertido);

    foreach(string element in listagem){
       
    if(element == getNomePokemon()){

        System.Console.WriteLine("Nome Pokemon: " + getNomePokemon());
    }
    
    else  if(element == getIdPokedex()){

        System.Console.WriteLine("ID: " + variavelAuxiliarId);
    }
    
    else if(element == dataCapturaConvertida){

        System.Console.WriteLine("Data de Captura : " + getDataCaptura());
    }
    
   else  if(element == nivelConvertido){

        System.Console.WriteLine("Nivel Pokemon: " + getNivelPokemon());
    }
    
    else if(element == AuxShinyConvertido){

        System.Console.WriteLine("É Shiny? : " + AuxShinyConvertido);
}
    
    else if(element == AuxPesoConvertido){

        System.Console.WriteLine("Peso: " + AuxPesoConvertido);
    }
    arquivo.Close();    
}



}










public void alterarDados(){

     try{

            }
catch{
    System.Console.WriteLine("Algo de Errado Ocorreu.");
}
}
public void ExcluirDados(){
     try{

            }
catch{
    System.Console.WriteLine("Algo de Errado Ocorreu.");
}
}


public void LerDados(){


        
}
  




    public void  pesquisarDadoPorID(){

    }











}   //Fim da classe.
} //Fim namespace.