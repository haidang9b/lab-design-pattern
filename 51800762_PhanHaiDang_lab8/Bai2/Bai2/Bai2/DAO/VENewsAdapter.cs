using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2.DAO
{
    public class VENewsAdapter : INewsDAO
    {
        private VnExpressService service;
        public VENewsAdapter()
        {
            service = new VnExpressService();
        }
        public List<NewsCategory> getAllCategory()
        {
            var categories = service.retrieveCats();
            var rs = new List<NewsCategory>();
            foreach(var item in categories)
            {
                rs.Add(new NewsCategory { categoryId = item.catID, categoryName = item.title });
            }
            return rs;

        }

        public List<NewsLocal> getNewsByCategory(int id)
        {
            var listNews = service.retrieveNews(id);
            var rs = new List<NewsLocal>();
            foreach (var item in listNews)
            {
                rs.Add(new NewsLocal { categoryId = id, newsContent = item.content, newsId = item.id, newsTitle = item.headline, NewsCategory = new NewsCategory { categoryId = id, categoryName = "" } });
            }
            return rs;
        }
    }
}