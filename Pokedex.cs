using System;
using System.Threading.Tasks;
namespace Assessment{ 
public class Pokedex : FuncoesMenu{             
    public void MostrarMenu(){
    String resposta;
    do { 

    System.Console.WriteLine("Saudacoes, usuario escolha [1] para que os dados sejam salvos em arquivo de texto | [2] Para ser salvo em lista. [3] Para procurar por um Nome de pokemon em específico | [4] Para excluir algum Dado | [6] Para Sair do programa. ");
        resposta = Console.ReadLine();

switch(resposta){

    case "1":

    SalvarEmTexto();
    break;

    case "2":

    SalvarEmLista();
    break; 

    case "3":

    pesquisarDadoPorNome();
    break;

    case "4":

    ExcluirDados();
    break;


    case "5":
    alterarDados();
    break;

    case "6":

    break;

    default:
    System.Console.WriteLine("Esperando Input correto");
    Thread.Sleep(1500);
    Console.Clear();
    break;   
} 

}while(resposta != "6");
}
    
    public void MenuFuncoes(){
 
            System.Console.WriteLine("Gostaria de Procurar por um Nome Específico?   [1] Para Sim || [2] Para Não.");
            String resposta = Console.ReadLine();

            switch(resposta){

                case "1":
                pesquisarDadoPorNome();
                break;

                default:
                System.Console.WriteLine("...................");
                Thread.Sleep(1500);
                Console.Clear();
                break;
           }
    }    
   }
}