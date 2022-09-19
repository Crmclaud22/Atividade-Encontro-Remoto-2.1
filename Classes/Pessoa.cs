using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_remoto_2.Classes
{
    //classe pessoa e ela e a superclasse ou classe abtrata
    public abstract class Pessoa
    {
        //atributos da classe Pessoa
      public string? Nome  { get; set; } 
      public string? Endereço { get; set; } 
      public float Rendimento { get; set; }
    }
}

//metodos acessores
//get : leitura
//set : edição
//por padrão esses métodos acessores vem como público, mas caso necessite coloque como privado
