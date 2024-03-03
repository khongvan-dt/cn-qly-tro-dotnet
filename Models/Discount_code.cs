using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    namespace quanLyTro.Models
    {
        public class Discount_code
        {
            [Key]
            public int? Id { get; set; }
            public string? Name { get; set; }
            public string? Code { get; set; }
            public string? Image { get; set; }
            public DateTime? TimeStart { get; set; }
            public DateTime? TimeEnd { get; set; }
            public int? SortOrder { get; set; }
            public int? ParentId { get; set; }
            public int? Created_by { get; set; }
            public int? Updated_by { get; set; }
            public int? Delete_by { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public DateTime? DeleteData { get; set; }

        }
    }

}
