using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AniBoxAPI.Models
{
    public class Avaliacao
    {
        //construtoress ↴

        public Avaliacao()
        {

        }

        public Avaliacao(int idNota, int nota, string comentario, Anime idAnime, Usuário idUsuario)
        {
            this.idNota = idNota;
            this.nota = nota;
            this.comentario = comentario;
            this.idAnime = idAnime;
            this.idUsuario = idUsuario;
        }




        //criando os atributos da classe avaliação <3
        public int idNota { get; set; }
        public int nota { get; set; }
        public string comentario { get; set; }
        public Anime idAnime { get; set; }
        public Usuário idUsuario { get; set; }
    }
}