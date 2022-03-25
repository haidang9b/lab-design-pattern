using Bai2.DAO;
using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        INewsDAO dao;
        public ActionResult Index(int? source = null, int? id = null)
        {
            int sourceID;
            if (source.HasValue)
            {
                Session["source"] = source;
                sourceID = (int)source;
            }
            else
            {
                sourceID = Session["source"]==null?-1:(int)Session["source"];
            }

            if (id.HasValue)
            {
                Session["idCate"] = id;
            }

            if (sourceID == 1)
            {
                dao = new TNNewsAdapter();
            }
            else if (sourceID == 2)
            {
                dao = new VENewsAdapter();
            }
            else
            {
                dao = new NewsDAO();
            }


            return View(new NewsViewModel
            {
                categories = dao.getAllCategory(),
                news = dao.getNewsByCategory(id ?? 1)
            });
        }


        public ActionResult Category(int id=0)
        {
            try
            {
                int source = Session["source"]==null?-1: (int)Session["source"];
                if (source == 1)
                {
                    dao = new TNNewsAdapter();
                }
                else if(source == 2)
                {
                    dao = new VENewsAdapter();
                }
                else
                {
                    dao = new NewsDAO();
                }

                if (id > 0)
                {
                    var news = dao.getNewsByCategory(id);
                    return View(news);
                }
                return HttpNotFound();
            }
            catch
            {
                return HttpNotFound();
            }
            
        }


        // GET: News/Details/5
        public ActionResult Details(int id)
        {
            int source = Session["source"] == null ? 0 : (int)Session["source"];
            if (source == 1)
            {
                dao = new TNNewsAdapter();
            }
            else if (source == 2)
            {
                dao = new VENewsAdapter();
            }
            else
            {
                dao = new NewsDAO();
            }
            var categories = dao.getAllCategory();
            var listNews = new List<NewsLocal>();
            foreach (var tmp in categories)
            {
                listNews.AddRange(dao.getNewsByCategory(tmp.categoryId));
            }
            var item = listNews.FirstOrDefault(u => u.newsId == id);
            return View(item);
        }

        // GET: News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: News/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: News/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
