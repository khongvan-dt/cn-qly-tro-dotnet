using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
    public string? Name { get; set; }
    public string? Logo { get; set; }
    public string? Website { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? Link { get; set; }
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
