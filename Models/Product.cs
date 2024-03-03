using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Product
    {

        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? Count { get; set; }
        public int? MenuId { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryIds { get; set; }
        public int? SupplierId { get; set; }
        public string? ProductColorIds { get; set; }
        public string? ProductSizeIds { get; set; }
        public int? ProductSettingId { get; set; }
        public string? ProductSettingIds { get; set; }
        public int? ProductInfoId { get; set; }
        public string? ProductInfoIds { get; set; }
        public int? Price { get; set; }
        public int? PromoPrice { get; set; }
        public int? TaxRates { get; set; }
        public string? TagsId { get; set; }
        public string? Images { get; set; }
        public string? Video { get; set; }
        public string? NoteSeo { get; set; }
        public int? SortOrder { get; set; }
        public int? IsActive { get; set; }
        public int? IsTranslate { get; set; }
        public int? Views { get; set; }
        public int? IsFront { get; set; }
        public int? IsHot { get; set; }
        public int? ParentId { get; set; }
        public int? create_by { get; set; }
        public int? IsRecycleBin { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }


    }
}
