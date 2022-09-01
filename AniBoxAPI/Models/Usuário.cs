using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AniBoxAPI.Models
{
    public class Usuário
    {
        //construtores ↴

        public Usuário()
        {

        }

        public Usuário(int idUsuario, string nomeUsu, string email, string senha)
        {
            this.idUsuario = idUsuario;
            this.nomeUsu = nomeUsu;
            this.email = email;
            this.senha = senha;
        }




        //criando os atributos da tabela usuário <3
        public int idUsuario { get; set; }
        public string nomeUsu { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}