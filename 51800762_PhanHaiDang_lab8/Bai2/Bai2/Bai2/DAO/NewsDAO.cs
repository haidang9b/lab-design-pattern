using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2.DAO
{
    public class NewsDAO: INewsDAO
    {
        private NewsContext db = new NewsContext();

        public List<NewsCategory> getAllCategory()
        {
            return db.newsCategory.ToList();
        }

        public List<NewsLocal> getNewsByCategory(int CategoryId)
        {
            return db.newsLocal.Where(n => n.categoryId == CategoryId).ToList();
        }
    }
}