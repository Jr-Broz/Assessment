using System;
using System.Threading.Tasks;
namespace Assessment{ 
public class Pokedex : FuncoesMenu{      
       

       

        public void MostrarMenu(){

    System.Console.WriteLine("Saudacoes, usuario escolha [1] para que os dados sejam salvos em arquivo de texto, [2] Para ser salvo em lista.");
    String resposta = Console.ReadLine();

switch(resposta){

    case "1":

    SalvarEmTexto();
    break;

    case "2":

    SalvarEmLista();
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