using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class New
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? MenuId { get; set; }
        public string? TagsId { get; set; }
        public int? SortOrder { get; set; }
        public string? Image { get; set; }
        public int? IsActive { get; set; }
        public int? IsTranslate { get; set; }
        public int? IsFront { get; set; }
        public int? Views { get; set; }
        public string? Tags { get; set; }
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
