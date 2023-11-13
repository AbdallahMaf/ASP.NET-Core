using AppDITI5MAF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppDITI5MAF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleDB _ArticleDB;

        public ArticlesController(ArticleDB ArticleDB)
        {
            _ArticleDB = ArticleDB;
        }

        [HttpGet]
        [Route("GetArticles")]
        public async Task<IEnumerable<Articles>> GetArticles()
        {
            return await _ArticleDB.Articles.ToListAsync();
        }


        [HttpPost]
        [Route("AddArticles")]

        public async Task<Articles> AddArticles(Articles objArticle)
        {
            _ArticleDB.Articles.Add(objArticle);
            await _ArticleDB.SaveChangesAsync();
            return objArticle;
        }

        [HttpPatch]
        [Route("UpdateArticles/{id}")]
        public async Task<Articles> UpdateArticles(Articles objArticle)
        {
            _ArticleDB.Entry(objArticle).State = EntityState.Modified;
            await _ArticleDB.SaveChangesAsync();
            return objArticle;
        }

        [HttpDelete]
        [Route("DeleteArticles/{id}")]

        public bool DeleteArticles(int id)
        {
            bool a = false;
            var article = _ArticleDB.Articles.Find(id);
            if (article != null)
            {
                a = true;
                _ArticleDB.Entry(article).State = EntityState.Deleted;  
                _ArticleDB.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;
        }


    }
}
