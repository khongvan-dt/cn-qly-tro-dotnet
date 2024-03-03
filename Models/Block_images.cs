using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Block_images
    {
        [Key]
        public int id { get; set; }
        public string? name { get; set; }
        public string? image { get; set; }
        public string? block_id { get; set; }
        public string? position { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }

    }
}
