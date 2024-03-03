using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace quanLyTro.Models
{
    public class Menu_data
    {
        [Key]
        public int id { get; set; }
        public string? name_data { get; set; }
        public string? language_id { get; set; }
        public string? data_id { get; set; }
        public string? description { get; set; }
        public string? content { get; set; }
        public string? meta_title { get; set; }
        public string? meta_description { get; set; }
        public string? meta_keywords { get; set; }
        public int? parent_id { get; set; }
        public int? sort_order { get; set; }
        public string? is_recycle_bin { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }

    }
}
