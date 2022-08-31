using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AniBoxAPI.Models
{
    public class Usuário
    {
        //criando os atributos da tabela usuário <3
        public int idUsuario { get; set; }
        public string nomeUsu { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}