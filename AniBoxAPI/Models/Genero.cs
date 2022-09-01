using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AniBoxAPI.Models
{
    public class Genero
    {
        // construtores ↴
        public Genero()
        {

        }
        public Genero (int idGenero, string nomeGenero)
        {
            this.idGenero = idGenero;
            this.nomeGenero = nomeGenero;
        }


        //criando os atributos da classe genero <3
        public int idGenero { get; set; }
        public string nomeGenero { get; set; }
    }
}