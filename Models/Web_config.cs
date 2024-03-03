using System.ComponentModel.DataAnnotations;

namespace quanLyTro.Models
{
    public class Web_config
    {
        [Key]
        public int Id { get; set; }
        public int? DataId { get; set; }
        public string? Name { get; set; }
        public string? Currency { get; set; }
        public string? CurrencyName { get; set; }
        public string? Logo { get; set; }
        public string? Website { get; set; }
        public string? Code { get; set; }
        public string? GoogleMap { get; set; }
        public string? GoogleAnalytic { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Zalo { get; set; }
        public string? FacebookId { get; set; }
        public string? Pinterest { get; set; }
        public string? Youtube { get; set; }
        public string? Dribbble { get; set; }
        public string? WhatsApp { get; set; }
        public string? Tiktok { get; set; }
        public string? Telegram { get; set; }
        public string? Google { get; set; }
        public string? Twitter { get; set; }
        public string? Shopee { get; set; }
        public string? Tiki { get; set; }
        public string? Lazada { get; set; }
        public string? Sendo { get; set; }
        public string? Instagram { get; set; }
        public string? Reddit { get; set; }
        public string? LinkedIn { get; set; }
        public string? GoogleTranslateApiKey { get; set; }
        public string? Layout { get; set; }
        public string? OtherConfig { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
        public int? Created_by { get; set; }
        public int? Updated_by { get; set; }
        public int? Delete_by { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteData { get; set; }
    }

}

