using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AniBoxAPI.Models
{
    public class Anime
    {
        //criando os construtores ↴
        public Anime()
        {

        }

        public Anime(int idAnime, string nomeAnime, string criador, int qtdeEP, int dataLanc, string sinopse, Genero idGenero)
        {
          this.idAnime = idAnime;
          this.nomeAnime = nomeAnime;
          this.criador = criador;
          this.qtdeEP = qtdeEP;
          this.dataLanc = dataLanc;
          this.sinopse = sinopse;
          this.idGenero = idGenero;
        }


        //criando os atributos da classe anime <3
        public int idAnime { get; set; }
        public string nomeAnime { get; set; }
        public string criador { get; set; }
        public int qtdeEP { get; set; }
        public int dataLanc { get; set; }
        public string sinopse { get; set; }
        public Genero idGenero { get; set; }
    }
}