using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2.DAO
{
    interface INewsDAO
    {
        List<NewsCategory> getAllCategory();
        List<NewsLocal> getNewsByCategory(int id);
    }
}
