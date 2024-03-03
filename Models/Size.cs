using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Size
    {
        [Key]
        public int id { get; set; }
        public int? products_id { get; set; }
        public string name { get; set; }
        public int? parent_id { get; set; }
        public int? sort_order { get; set; }
       public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }
    }

}
