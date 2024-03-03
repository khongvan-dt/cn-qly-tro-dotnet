using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Block
    {
        [Key]
        public int id { get; set; }
        public string? name { get; set; }
        public string? blockTypeid { get; set; }
        public string? image { get; set; }
        public string? images { get; set; }
        public int? parentid { get; set; }
        public int? blockinfoid { get; set; }
        public int? sortOrder { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }

    }
}
