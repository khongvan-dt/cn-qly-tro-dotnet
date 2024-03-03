using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    namespace quanLyTro.Models
    {
        public class Category
        {
            [Key]
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Image { get; set; }
            public string? IsFront { get; set; }
            public int? IsActive { get; set; }
            public int? ParentId { get; set; }
            public int? SortOrder { get; set; }
            public int? IsRecycleBin { get; set; }
            public int? Created_by { get; set; }
            public int? Updated_by { get; set; }
            public int? Delete_by { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public DateTime? DeleteData { get; set; }

        }
    }

}
