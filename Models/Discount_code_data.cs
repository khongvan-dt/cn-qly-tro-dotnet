using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    namespace quanLyTro.Models
    {
        public class Discount_code_data
        {
            [Key]

            public int? id { get; set; }
            public string? name_data { get; set; }
            public int? data_id { get; set; }
            public int? languages_id { get; set; }
            public string? description { get; set; }
            public string? content { get; set; }
            public int? sort_order { get; set; }
            public int? parent_id { get; set; }
            public int? Created_by { get; set; }
            public int? Updated_by { get; set; }
            public int? Delete_by { get; set; }
            public DateTime? CreatedDate { get; set; }
            public DateTime? UpdatedDate { get; set; }
            public DateTime? DeleteData { get; set; }
        }
    }

}
