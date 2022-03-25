using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bai2.Models
{
    public class NewsContext : DbContext
    {
        /*
            enable-migrations
            add-migration "name_migration"
            update-database
         */
        public NewsContext() : base("51800762_Lab8DesignPattern") { }
        public DbSet<NewsCategory> newsCategory { get; set; }
        public DbSet<NewsLocal> newsLocal { get; set; }
    }
}