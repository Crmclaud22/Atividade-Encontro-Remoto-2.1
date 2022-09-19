using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_remoto_2.Classes
{
    //classe Pessoa Física que herda da superclasse Pessoa
    public class PessoaFisica: Pessoa
    {
        //criamos os atributos da classe pesso Fisica
       public string? Cpf { get; set; } 
       public DateTime DataNascimento { get; set; }
    }
}