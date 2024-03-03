using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Color_Data
    {
        [Key]
        public int Id { get; set; }
        public string? NameData { get; set; }
        public string? DataId { get; set; }
        public string? LanguagesId { get; set; }
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
