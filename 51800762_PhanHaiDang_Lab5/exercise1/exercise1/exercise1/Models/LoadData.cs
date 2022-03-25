using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercise1.Models
{
    enum TypeDB
    {
        MSSQL,
        MySQL
    }
    public static class LoadData
    {
        public static string connecstring2 = "Data Source=DROM\\SQLEXPRESS;Initial Catalog=SINHVIEN51800762;Integrated Security=True";
        public static string connecstring1 = "Data Source=127.0.0.1;port=3306;Integrated Security=False;Initial Catalog=sinhvien; User=root;Password=;";
        public static int typeData = 0;


    }
}