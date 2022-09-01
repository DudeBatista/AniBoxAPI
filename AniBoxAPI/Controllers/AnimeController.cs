using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AniBoxAPI.Models;

namespace AniBoxAPI.Controllers
{
    public class AnimeController : ApiController
    {

        [HttpGet]
        [ActionName ("getAll")]
        public IEnumerable <Anime> getAllAnimes()
        {
            try
            {
                SqlConnectionController db = new SqlConnectionController();
                var l = db.BuscaAnime();
                db.Fechar();
                return l;
            }
            catch(Exception e)
            {
                var resp =  new HttpResponseMessage(HttpStatusCode.Unauthorized);
                throw new HttpResponseException(resp);
            }
        }

        // GET: api/Anime/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Anime
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Anime/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Anime/5
        public void Delete(int id)
        {
        }
    }
}
