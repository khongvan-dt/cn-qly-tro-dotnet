using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class About_data
    {
        [Key]
        public int Id { get; set; }
        public string? NameData { get; set; }
        public int? DataId { get; set; }
        public int? LanguagesId { get; set; }
        public string? Content { get; set; }
        public string? Description { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeyword { get; set; }
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
