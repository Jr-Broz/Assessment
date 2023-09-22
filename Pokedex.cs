using System;
using System.Threading.Tasks;
namespace Assessment{ 
public class Pokedex : FuncoesMenu{
      
        public Pokedex(string NomePokemon, double PesoPokemon, bool Eh_Pokemon_Shiny, int NivelPokemon, DateTime dataDaCaptura, String IdPokedex) : 
        
        base(NomePokemon, PesoPokemon, Eh_Pokemon_Shiny, NivelPokemon, dataDaCaptura, IdPokedex)
        {
        }

        public void MostrarMenu(){

    System.Console.WriteLine("Saudacoes, usuario escolha [1] para que os dados sejam salvos em arquivo de texto, [2] Para ser salvo em lista.");
    String resposta = Console.ReadLine();

switch(resposta){


    case "1":

    SalvarEmLista();
    break;

    case "2":

    SalvarEmTexto();
    break; 

    default:
    System.Console.WriteLine("Esperando Input correto");
    Thread.Sleep(1500);
    Console.Clear();
    break;
}



}


    }
}