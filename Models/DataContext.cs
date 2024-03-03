using Microsoft.EntityFrameworkCore;
using quanLyTro.Models;
using quanLyTro.Models.quanLyTro.Models;

namespace quanLyTro.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<About_data> About_datas { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Block_data> Block_datas { get; set; }
        public DbSet<Block_images> Block_images { get; set; }
        public DbSet<Block_info_data> Block_info_datas { get; set; }
        public DbSet<Block_Info> Block_infos { get; set; }
        public DbSet<Block_item> Block_items { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Category_Data> Categorys_datas { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Color_Data> Colors_datas { get; set; }
        public DbSet<Discount_code> Discount_codes { get; set; }
        public DbSet<Discount_code_data> Discount_code_datas { get; set; }
        public DbSet<Image_Data> Image_Datas { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Images_type> Images_Types { get; set; }
        public DbSet<Link_footer> Link_footers { get; set; }
        public DbSet<Menu_data> Menu_datas { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<News_data> News_datas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product_color> Product_Colors { get; set; }
        public DbSet<Product_size> Product_Sizes { get; set; }
        public DbSet<Products_data> Products_Datas { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Size_data> Size_datas { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }


        public DbSet<Web_config_data> web_config_data { get; set; }
        public DbSet<Web_config> web_configs { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tùy chỉnh cấu hình thêm (nếu cần)

            // Ví dụ: Thiết lập cấu hình cho các quan hệ, khóa ngoại, các ràng buộc, vv.
        }
    }
}
