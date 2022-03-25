using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2.DAO
{
    public class TNNewsAdapter : INewsDAO
    {
        private ThanhNienService service;

        public TNNewsAdapter()
        {
            service = new ThanhNienService();
        }
        public List<NewsCategory> getAllCategory()
        {
            var categories = service.getCategories();

            var rs = new List<NewsCategory>();
            foreach(var item in categories)
            {
                rs.Add(new NewsCategory { categoryId = item.id, categoryName = item.title });
            }
            return rs;
        }

        public List<NewsLocal> getNewsByCategory(int id)
        {

            var news = service.getNewsList(id);
            var rs = new List<NewsLocal>();
            foreach(var item in news)
            {
                rs.Add(new NewsLocal { newsId = item.id, categoryId = id, newsContent = item.content, newsTitle = item.title, NewsCategory=new NewsCategory { categoryId=id,categoryName =""} });
            }
            return rs;
        }
    }
}