using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class News_data
    {
        [Key]
        public int Id { get; set; }
        public string? Name_data { get; set; }
        public string? language_id { get; set; }
        public string? data_id { get; set; }
        public string? description { get; set; }
        public string? content { get; set; }
        public string? meta_keyword { get; set; }
        public string? meta_description { get; set; }
        public int? parent_id { get; set; }
        public int? is_recycle_bin { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }


    }
}
