using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Products_data
    {
        [Key]
        public int? Id { get; set; }
        public string? NameData { get; set; }
        public int? LanguagesId { get; set; }
        public int? DataId { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
        public string? ContentPromo { get; set; }
        public int? ParentId { get; set; }
        public int? IsRecycleBin { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }
    }
}
