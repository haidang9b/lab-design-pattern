using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bai2.Models
{
    [Table("NewsCategory")]
    public class NewsCategory
    {
        [Key]
        [DisplayName("Mã loại")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; }

        [StringLength(300, MinimumLength = 3, ErrorMessage = "Độ dài tên của loại  tin tức phải từ 3 kí tự trở lên")]
        [DisplayName("Tên loại tin tức")]
        public string categoryName { get; set; }
        public virtual ICollection<NewsLocal> NewsLocals { get; set; }
    }
}