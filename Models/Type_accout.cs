using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Type_accout
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }
    }

}
