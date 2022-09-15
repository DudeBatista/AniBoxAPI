using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AniBoxAPI.Models;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AniBoxAPI.Controllers
{
    public class AnimeController : ApiController
    {

        [HttpGet]
        [ActionName("getAll")]
        public IEnumerable<Anime> getAllAnimes()
        {
            try
            {
                SqlConnectionController db = new SqlConnectionController();
                var l = db.BuscaAnime();
                db.Fechar();
                return l;
            }
            catch (Exception e)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                throw new HttpResponseException(resp);
            }
        }

        //arrumar os return
        // tedstandi testando
        [HttpGet]
        [ActionName("GetAnimeByName")]
        public IEnumerable<Anime> GetAnimeByName(string name){

            try
            {
                SqlConnectionController db = new SqlConnectionController();
                var pega = db.GetAnimeByParameter("nomeAnime", name);
                db.Fechar();
                return pega;
            }
            catch(Exception e)
            {
                var pega = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                throw new HttpResponseException(pega);
            }
        }

        [HttpGet]
        [ActionName("GetAnimeByGenero")]
        public IEnumerable<Anime> GetAnimeByGenero(string genero)
        {

            try
            {
                SqlConnectionController db = new SqlConnectionController();
                var pega = db.GetAnimeByParameter("nomeGenero", genero);
                db.Fechar();
                return pega;
            }
            catch (Exception e)
            {
                var pega = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                throw new HttpResponseException(pega);
            }
        }

    }
}
