using Controle_de_Clientes;
using Controle_de_Clientes.Classe;

string? opcao;

do
{
    Console.Clear();

    Console.WriteLine (@"
    1 - Cadastrar PJ
    2 - Sair
    ");
    opcao = Console.ReadLine();

    PessoaJuridica metodosPJ = new PessoaJuridica();

    if (opcao  == "1")
    {

  PessoaJuridica PJ = new PessoaJuridica();

  Console.WriteLine("Digite o nome PJ; ");
  PJ.nome = Console.ReadLine();

  Console.WriteLine("Informe o rendimento da pessoa PJ; ");
  PJ.nome = Console.ReadLine();

  Console.WriteLine("Digite o CNPJ; ");
  PJ.CNPJ =  Console.ReadLine();
  metodosPJ.Inserir(PJ);
  

  Console.WriteLine("Cadatro realizado co sucesso! :) ");
  Console.WriteLine("Aperte uma TECLA para continuar ");
  Console.ReadLine();
    }else if (opcao == "2"){
  Console.WriteLine("Obrigado por usar nosso programa");
 } else {
     Console.WriteLine("Opçao Invalida");

 }
} while (opcao != "2");
