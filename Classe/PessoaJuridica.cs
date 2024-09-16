using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Clientes.Classe
{
    public class PessoaJuridica : Pessoa
    {
       public string? CNPJ {get; set;}

       public void Inserir(PessoaJuridica pj) {

        using (StreamWriter sw = new StreamWriter (pj.nome+".txt"))
        {
            sw.WriteLine ($"{pj.nome},{pj.Rendimento},{pj.CNPJ}");
        }
       }
     }
}