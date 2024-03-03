using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Image { get; set; }
        public string? Gender { get; set; }
        public string? Birthday { get; set; }
        public string? Address { get; set; }
        public int type_id { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public string? Password { get; set; }
        public int? SortOrder { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }
    }

}
