using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string DisplayName { get; set; }
        public string DisplayType { get; set; }
        public int? Position { get; set; }
        public string MetaTitle { get; set; }
        public int? ParentId { get; set; }
        public int? SortOrder { get; set; }
        public string TypeSubMenu { get; set; }
        public string IsFront { get; set; }
        public string CurrentLink { get; set; }
        public string IsRegister { get; set; }
        public string Icon { get; set; }
        public int? IsActive { get; set; }
        public int? IsRecycleBin { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }

    }
}
