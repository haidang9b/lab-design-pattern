using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2.Models
{
    public class NewsViewModel
    {
        public List<NewsCategory> categories { get; set; }
        public List<NewsLocal> news { get; set; }
    }
}