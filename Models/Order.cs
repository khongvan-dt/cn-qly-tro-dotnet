using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Order
    {
[Key]
        public int id { get; set; }
        public string? name { get; set; }
        public string? user_id { get; set; }
        public string? product_id { get; set; }
        public string? price { get; set; }
        public string? promo_price { get; set; }
        public string? note { get; set; }
        public string? sort_order { get; set; }
        public int? quantity { get; set; }
        public string? is_payment { get; set; }
        public int? invoice { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public int? is_view { get; set; }
       public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }

    }
}
