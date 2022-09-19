using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_remoto_2.Classes
{
    //classe Pessoa Jurpidica herda da Super Classe Pessoa
    public class PessoaJurica: Pessoa
    {
        //atributos da Classe Pessoa Jurídica
      public string? RazaoSocial { get; set; }
      public string? Cnpj { get; set; }
    }
}