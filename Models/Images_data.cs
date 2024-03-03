
using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Image_Data
    {
        [Key] public int Id { get; set; }
        public string? NameData { get; set; }
        public string? DataId { get; set; }
        public string? LanguagesId { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
        public string? SortOrder { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }

    }
}
