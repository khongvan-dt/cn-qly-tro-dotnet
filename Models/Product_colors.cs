using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Product_color
    {
        [Key]
        public int? Id { get; set; }
        public int? Name { get; set; }
        public string? PriceUp { get; set; }
        public string? Count { get; set; }
        public string? Image { get; set; }
        public string? Images { get; set; }
        public int? ProductId { get; set; }
        public int? ParentId { get; set; }
        public int? SortOrder { get; set; }
       public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }

    }
}
