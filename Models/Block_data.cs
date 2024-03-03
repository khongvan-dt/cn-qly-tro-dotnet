using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Block_data
    {
        [Key]
        public int id { get; set; }
        public string? name_data { get; set; }
        public string? data_id { get; set; }
        public string? languages_id { get; set; }
        public string? description { get; set; }
        public string? content { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }

    }
}
