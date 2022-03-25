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
    [Table("NewsLocal")]
    public class NewsLocal
    {
        [Key]
        [DisplayName("Mã tin tức")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int newsId { get; set; }

        [StringLength(300, MinimumLength = 3, ErrorMessage = "Độ dài tên của loại  tin tức phải từ 3 kí tự trở lên")]
        [DisplayName("Tiêu đề")]
        public string newsTitle { get; set; }
        
        [DisplayName("Nội dung")]
        public string newsContent { get; set; }

        [DisplayName("Loại tin tức")]
        [JsonIgnore]
        public int categoryId { get; set; }
        [ForeignKey("categoryId")]
        public virtual NewsCategory NewsCategory { get; set; }
    }
}