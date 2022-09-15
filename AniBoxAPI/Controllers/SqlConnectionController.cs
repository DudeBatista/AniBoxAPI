using AniBoxAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AniBoxAPI.Models;

namespace AniBoxAPI.Controllers
{
    public class SqlConnectionController : Controller
    {
        MySqlConnection conexao;

        static string host = "localhost";
        static string database = "dbAniBox";
        static string userDB = "root";
        static string password = "12345678";
        public static string strProvider = "server=" + host +
                                            ";Database=" + database +
                                            ";User ID=" + userDB +
                                            ";Password=" + password;
        public static Boolean novo = false;
        public String sql;

        public SqlConnectionController()
        {
            conexao = new MySqlConnection(strProvider);
            conexao.Open();
        }
        public List<Anime> BuscaAnime()
        {
            MySqlDataReader reader;
            sql = "SELECT * FROM tbAnime;";
            MySqlCommand cmd = new MySqlCommand(sql,conexao);
            reader = cmd.ExecuteReader();
            List<Anime> l = new List<Anime>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    l.Add(new Anime(int.Parse(reader["idAnime"].ToString()),
                        reader["nomeAnime"].ToString(),
                        reader["criador"].ToString(),
                        int.Parse(reader["qtdeEP"].ToString()),
                        int.Parse(reader["dataLanc"].ToString()),
                        reader["sinopse"].ToString(),
                        new Genero(int.Parse(reader["idGenero"].ToString()),"")));
                }
            }
            return l;
        }

        internal object GetAnimeByParameter(string v, string name)
        {
            throw new NotImplementedException();
        }

        public void Fechar()
        {
            conexao.Close();
        }
    }
}