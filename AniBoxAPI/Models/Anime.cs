using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AniBoxAPI.Models
{
    public class Anime
    {
        //criando os atributos da classe anime <3
        public int idAnime { get; set; }
        public string nomeAnime { get; set; }
        public string criador { get; set; }
        public int qtdeEP { get; set; }
        public string dataLanc { get; set; }
        public string sinopse { get; set; }
        public Genero idGenero { get; set; }
    }
}