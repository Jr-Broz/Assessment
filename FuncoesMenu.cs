using System;
using System.IO;
namespace Assessment{ 
public class FuncoesMenu : IFuncoes{

        protected String NomePokemon;
        protected double PesoPokemon;
       protected bool Eh_Pokemon_Shiny;
        protected int NivelPokemon;
        protected DateTime dataDaCaptura;
        protected String IdPokedex; 

        public FuncoesMenu(String NomePokemon, double PesoPokemon, bool Eh_Pokemon_Shiny, int NivelPokemon, DateTime dataDaCaptura, String IdPokedex) {

            this.NomePokemon = NomePokemon;
            this.PesoPokemon = PesoPokemon;
            this.Eh_Pokemon_Shiny = Eh_Pokemon_Shiny;
            this.NivelPokemon = NivelPokemon;
            this.dataDaCaptura = dataDaCaptura;
            this.IdPokedex = IdPokedex;


        }

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

        double variavelAuxiliarPeso;
        bool variavelAuxiliarShiny;

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

FileStream f = new FileStream("Arquivos_Pokedex.txt", FileMode.OpenOrCreate);
StreamWriter arquivar = new StreamWriter(f);
List<String> listagem = new List<string>();

listagem.Add(getNomePokemon());
listagem.Add(getIdPokedex());

String dataCapturaConvertida = Convert.ToString(dataDaCaptura);
String nivelConvertido = Convert.ToString(getNivelPokemon());
String AuxShinyConvertido = Convert.ToString(variavelAuxiliarShiny);
String AuxPesoConvertido = Convert.ToString(variavelAuxiliarPeso);

foreach(string element in listagem){
       
        arquivar.WriteLine("Nome do Pokemon: " + getNomePokemon());
        arquivar.WriteLine("Nivel: " + nivelConvertido);
        arquivar.WriteLine("É Shiny: " + AuxShinyConvertido);
        arquivar.WriteLine("Peso: " + AuxPesoConvertido);
        arquivar.WriteLine("ID: " + getIdPokedex());
}

    arquivar.Close();
    f.Close();

}
 
    catch{

    System.Console.WriteLine("Ocorreu um Erro ao Cadastrar O Pokemon na Pokedex.");

}
    }


    public void SalvarEmLista(){

            try{

            }
catch{
    System.Console.WriteLine("Algo de Errado Ocorreu.");
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

 try{

    












            }
catch{
    System.Console.WriteLine("Algo de Errado Ocorreu.");
}



}
    public void  pesquisarDados(){

    }











}   
}